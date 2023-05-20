import pyodbc
from PyQt5 import QtWidgets
from matplotlib.backends.backend_qt5agg import FigureCanvasQTAgg as FigureCanvas
from matplotlib.figure import Figure
import locale

# Defina o locale para formatar os valores como reais (R$)
locale.setlocale(locale.LC_ALL, 'pt_BR.utf8')

server = '<server>.database.windows.net'
database = '<database>'
username = '<username>'
password = '<password>'
driver = '{ODBC Driver 17 for SQL Server}' # or 'SQL Server'

cnxn = pyodbc.connect(
    f'DRIVER={driver};SERVER={server};PORT=1433;DATABASE={database};UID={username};PWD={password}'
)


cursor = cnxn.cursor()

# Consulta para obter os dados para a primeira visualização
query1 = """
SELECT TOP 10 NomeFavorecido, ValorTotalRecebido
FROM ResumoFavorecido
ORDER BY ValorTotalRecebido DESC
"""

cursor.execute(query1)
results1 = cursor.fetchall()

# Consulta para obter os dados para a segunda visualização
query2 = """
SELECT SiglaUF, COUNT(DISTINCT CodigoFavorecido) as NumFavorecidos
FROM Recebimento
GROUP BY SiglaUF
ORDER BY NumFavorecidos DESC
"""

cursor.execute(query2)
results2 = cursor.fetchall()

# Consulta para obter os dados para a terceira visualização
query3 = """
SELECT TOP 10 NomeOrgaoSuperior, SUM(ValorRecebido) as TotalRecebido
FROM Recebimento JOIN OrgaoSuperior ON Recebimento.CodigoOrgaoSuperior = OrgaoSuperior.CodigoOrgaoSuperior
GROUP BY NomeOrgaoSuperior
ORDER BY TotalRecebido DESC
"""

cursor.execute(query3)
results3 = cursor.fetchall()


cursor.close()
cnxn.close()



class MainWindow(QtWidgets.QMainWindow):
    def __init__(self):
        super().__init__()

        central_widget = QtWidgets.QWidget()
        self.setCentralWidget(central_widget)

        main_layout = QtWidgets.QVBoxLayout()
        central_widget.setLayout(main_layout)

        h_layout = QtWidgets.QHBoxLayout()
        main_layout.addLayout(h_layout)


        fig1 = Figure()
        ax1 = fig1.add_subplot(111)
        ax1.bar([row[0] for row in results1], [row[1]/1000000000 for row in results1])
        ax1.set_title('Top 10 Favorecidos por Valor Total Recebido')
        ax1.set_xlabel('Nome Favorecido')
        ax1.set_ylabel('Valor Total Recebido (bilhões de R$)')
        

        ax1.yaxis.set_major_formatter(lambda x, pos: locale.currency(x, grouping=True))
        

        for label in ax1.get_xticklabels():
            label.set_rotation(10)
            label.set_ha('right')
            
        fig1.subplots_adjust(bottom=0.3, left=0.2)
        
        canvas1 = FigureCanvas(fig1)
        h_layout.addWidget(canvas1, stretch=2)

 
        fig2 = Figure()
        ax2 = fig2.add_subplot(111)
        ax2.pie([row[1] for row in results2], labels=[row[0] for row in results2])
        ax2.set_title('Número de Favorecidos por UF')
        canvas2 = FigureCanvas(fig2)
        h_layout.addWidget(canvas2, stretch=1)


        fig3 = Figure()
        ax3 = fig3.add_subplot(111)
        ax3.plot([row[0] for row in results3], [row[1]/1000000000 for row in results3])
        ax3.set_title('Top 10 Órgãos Superiores por Total Recebido')
        ax3.set_xlabel('Nome do Órgão Superior')
        ax3.set_ylabel('Total Recebido (bilhões de R$)')
        

        ax3.yaxis.set_major_formatter(lambda x, pos: locale.currency(x, grouping=True))
        

        for label in ax3.get_xticklabels():
            label.set_rotation(10)
            label.set_ha('right')
        
        fig3.subplots_adjust(bottom=0.3)
        
        canvas3 = FigureCanvas(fig3)
        main_layout.addWidget(canvas3)

if __name__ == '__main__':
    app = QtWidgets.QApplication([])
    window = MainWindow()
    window.show()
    app.exec_()
