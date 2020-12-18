﻿using System;

namespace GrapeCity.ActiveReports.Samples.Web.CodeReports
{
	/// <summary>
	/// Summary description for NWindLabelsFiltered.
	/// </summary>
	public partial class NwindLabelsFiltered : GrapeCity.ActiveReports.SectionReport
	{
		System.Data.DataTable table = new System.Data.DataTable("Results");
		int counter = 0;

		public NwindLabelsFiltered()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();
		}

		private void ActiveReport_DataInitialize(object sender, System.EventArgs args)
		{
			table.Columns.Add("CustomerID", typeof(String));
			this.Fields.Add("CustomerID");
			table.Columns.Add("CompanyName", typeof(String));
			this.Fields.Add("CompanyName");
			table.Columns.Add("ContactName", typeof(String));
			this.Fields.Add("ContactName");
			table.Columns.Add("ContactTitle", typeof(String));
			this.Fields.Add("ContactTitle");
			table.Columns.Add("Address", typeof(String));
			this.Fields.Add("Address");
			table.Columns.Add("City", typeof(String));
			this.Fields.Add("City");
			table.Columns.Add("Region", typeof(String));
			this.Fields.Add("Region");
			table.Columns.Add("PostalCode", typeof(String));
			this.Fields.Add("PostalCode");
			table.Columns.Add("Country", typeof(String));
			this.Fields.Add("Country");
			table.Columns.Add("Phone", typeof(String));
			this.Fields.Add("Phone");
			table.Columns.Add("Fax", typeof(String));
			this.Fields.Add("Fax");
			table.Rows.Add(new object[] { "ALFKI", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Obere Str. 57", "Berlin", null, "12209", "Germany", "030-0074321", "030-0076545", });
			table.Rows.Add(new object[] { "ANATR", "Ana Trujillo Emparedados y helados", "Ana Trujillo", "Owner", "Avda. de la Constitucion 2222", "Mexico D.F.", null, "05021", "Mexico", "(5) 555-4729", "(5) 555-3745", });
			table.Rows.Add(new object[] { "ANTON", "Antonio Moreno Taqueria", "Antonio Moreno", "Owner", "Mataderos  2312", "Mexico D.F.", null, "05023", "Mexico", "(5) 555-3932", null, });
			table.Rows.Add(new object[] { "AROUT", "Around the Horn", "Thomas Hardy", "Sales Representative", "120 Hanover Sq.", "London", null, "WA1 1DP", "UK", "(171) 555-7788", "(171) 555-6750", });
			table.Rows.Add(new object[] { "BERGS", "Berglunds snabbkop", "Christina Berglund", "Order Administrator", "Berguvsvagen  8", "Lulee", null, "S-958 22", "Sweden", "0921-12 34 65", "0921-12 34 67", });
			table.Rows.Add(new object[] { "BLAUS", "Blauer See Delikatessen", "Hanna Moos", "Sales Representative", "Forsterstr. 57", "Mannheim", null, "68306", "Germany", "0621-08460", "0621-08924", });
			table.Rows.Add(new object[] { "BLONP", "Blondel pere et fils", "Frederique Citeaux", "Marketing Manager", "24, place Kleber", "Strasbourg", null, "67000", "France", "88.60.15.31", "88.60.15.32", });
			table.Rows.Add(new object[] { "BOLID", "Bolido Comidas preparadas", "Martin Sommer", "Owner", "C/ Araquil, 67", "Madrid", null, "28023", "Spain", "(91) 555 22 82", "(91) 555 91 99", });
			table.Rows.Add(new object[] { "BONAP", "Bon app'", "Laurence Lebihan", "Owner", "12, rue des Bouchers", "Marseille", null, "13008", "France", "91.24.45.40", "91.24.45.41", });
			table.Rows.Add(new object[] { "BOTTM", "Bottom-Dollar Markets", "Elizabeth Lincoln", "Accounting Manager", "23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada", "(604) 555-4729", "(604) 555-3745", });
			table.Rows.Add(new object[] { "BSBEV", "B's Beverages", "Victoria Ashworth", "Sales Representative", "Fauntleroy Circus", "London", null, "EC2 5NT", "UK", "(171) 555-1212", null, });
			table.Rows.Add(new object[] { "CACTU", "Cactus Comidas para llevar", "Patricio Simpson", "Sales Agent", "Cerrito 333", "Buenos Aires", null, "1010", "Argentina", "(1) 135-5555", "(1) 135-4892", });
			table.Rows.Add(new object[] { "CENTC", "Centro comercial Moctezuma", "Francisco Chang", "Marketing Manager", "Sierras de Granada 9993", "Mexico D.F.", null, "05022", "Mexico", "(5) 555-3392", "(5) 555-7293", });
			table.Rows.Add(new object[] { "CHOPS", "Chop-suey Chinese", "Yang Wang", "Owner", "Hauptstr. 29", "Bern", null, "3012", "Switzerland", "0452-076545", null, });
			table.Rows.Add(new object[] { "COMMI", "Comercio Mineiro", "Pedro Afonso", "Sales Associate", "Av. dos Lusiadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil", "(11) 555-7647", null, });
			table.Rows.Add(new object[] { "CONSH", "Consolidated Holdings", "Elizabeth Brown", "Sales Representative", "Berkeley Gardens12  Brewery ", "London", null, "WX1 6LT", "UK", "(171) 555-2282", "(171) 555-9199", });
			table.Rows.Add(new object[] { "DRACD", "Drachenblut Delikatessen", "Sven Ottlieb", "Order Administrator", "Walserweg 21", "Aachen", null, "52066", "Germany", "0241-039123", "0241-059428", });
			table.Rows.Add(new object[] { "DUMON", "Du monde entier", "Janine Labrune", "Owner", "67, rue des Cinquante Otages", "Nantes", null, "44000", "France", "40.67.88.88", "40.67.89.89", });
			table.Rows.Add(new object[] { "EASTC", "Eastern Connection", "Ann Devon", "Sales Agent", "35 King George", "London", null, "WX3 6FW", "UK", "(171) 555-0297", "(171) 555-3373", });
			table.Rows.Add(new object[] { "ERNSH", "Ernst Handel", "Roland Mendel", "Sales Manager", "Kirchgasse 6", "Graz", null, "8010", "Austria", "7675-3425", "7675-3426", });
			table.Rows.Add(new object[] { "FAMIA", "Familia Arquibaldo", "Aria Cruz", "Marketing Assistant", "Rua Oros, 92", "Sao Paulo", "SP", "05442-030", "Brazil", "(11) 555-9857", null, });
			table.Rows.Add(new object[] { "FISSA", "FISSA Fabrica Inter. Salchichas S.A.", "Diego Roel", "Accounting Manager", "C/ Moralzarzal, 86", "Madrid", null, "28034", "Spain", "(91) 555 94 44", "(91) 555 55 93", });
			table.Rows.Add(new object[] { "FOLIG", "Folies gourmandes", "Martine Rance", "Assistant Sales Agent", "184, chaussee de Tournai", "Lille", null, "59000", "France", "20.16.10.16", "20.16.10.17", });
			table.Rows.Add(new object[] { "FOLKO", "Folk och fa HB", "Maria Larsson", "Owner", "ekergatan 24", "Brucke", null, "S-844 67", "Sweden", "0695-34 67 21", null, });
			table.Rows.Add(new object[] { "FRANK", "Frankenversand", "Peter Franken", "Marketing Manager", "Berliner Platz 43", "Munchen", null, "80805", "Germany", "089-0877310", "089-0877451", });
			table.Rows.Add(new object[] { "FRANR", "France restauration", "Carine Schmitt", "Marketing Manager", "54, rue Royale", "Nantes", null, "44000", "France", "40.32.21.21", "40.32.21.20", });
			table.Rows.Add(new object[] { "FRANS", "Franchi S.p.A.", "Paolo Accorti", "Sales Representative", "Via Monte Bianco 34", "Torino", null, "10100", "Italy", "011-4988260", "011-4988261", });
			table.Rows.Add(new object[] { "FURIB", "Furia Bacalhau e Frutos do Mar", "Lino Rodriguez ", "Sales Manager", "Jardim das rosas n. 32", "Lisboa", null, "1675", "Portugal", "(1) 354-2534", "(1) 354-2535", });
			table.Rows.Add(new object[] { "GALED", "Galeria del gastronomo", "Eduardo Saavedra", "Marketing Manager", "Rambla de Catalunya, 23", "Barcelona", null, "08022", "Spain", "(93) 203 4560", "(93) 203 4561", });
			table.Rows.Add(new object[] { "GODOS", "Godos Cocina Tipica", "Jose Pedro Freyre", "Sales Manager", "C/ Romero, 33", "Sevilla", null, "41101", "Spain", "(95) 555 82 82", null, });
			table.Rows.Add(new object[] { "GOURL", "Gourmet Lanchonetes", "Andre Fonseca", "Sales Associate", "Av. Brasil, 442", "Campinas", "SP", "04876-786", "Brazil", "(11) 555-9482", null, });
			table.Rows.Add(new object[] { "GREAL", "Great Lakes Food Market", "Howard Snyder", "Marketing Manager", "2732 Baker Blvd.", "Eugene", "OR", "97403", "USA", "(503) 555-7555", null, });
			table.Rows.Add(new object[] { "GROSR", "GROSELLA-Restaurante", "Manuel Pereira", "Owner", "5 Ave. Los Palos Grandes", "Caracas", "DF", "1081", "Venezuela", "(2) 283-2951", "(2) 283-3397", });
			table.Rows.Add(new object[] { "HANAR", "Hanari Carnes", "Mario Pontes", "Accounting Manager", "Rua do Paco, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil", "(21) 555-0091", "(21) 555-8765", });
			table.Rows.Add(new object[] { "HILAA", "HILARIoN-Abastos", "Carlos Hernandez", "Sales Representative", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristobal", "Tachira", "5022", "Venezuela", "(5) 555-1340", "(5) 555-1948", });
			table.Rows.Add(new object[] { "HUNGC", "Hungry Coyote Import Store", "Yoshi Latimer", "Sales Representative", "City Center Plaza516 Main St.", "Elgin", "OR", "97827", "USA", "(503) 555-6874", "(503) 555-2376", });
			table.Rows.Add(new object[] { "HUNGO", "Hungry Owl All-Night Grocers", "Patricia McKenna", "Sales Associate", "8 Johnstown Road", "Cork", "Co. Cork", null, "Ireland", "2967 542", "2967 3333", });
			table.Rows.Add(new object[] { "ISLAT", "Island Trading", "Helen Bennett", "Marketing Manager", "Garden HouseCrowther Way", "Cowes", "Isle of Wight", "PO31 7PJ", "UK", "(198) 555-8888", null, });
			table.Rows.Add(new object[] { "KOENE", "Koniglich Essen", "Philip Cramer", "Sales Associate", "Maubelstr. 90", "Brandenburg", null, "14776", "Germany", "0555-09876", null, });
			table.Rows.Add(new object[] { "LACOR", "La corne d'abondance", "Daniel Tonini", "Sales Representative", "67, avenue de l'Europe", "Versailles", null, "78000", "France", "30.59.84.10", "30.59.85.11", });
			table.Rows.Add(new object[] { "LAMAI", "La maison d'Asie", "Annette Roulet", "Sales Manager", "1 rue Alsace-Lorraine", "Toulouse", null, "31000", "France", "61.77.61.10", "61.77.61.11", });
			table.Rows.Add(new object[] { "LAUGB", "Laughing Bacchus Wine Cellars", "Yoshi Tannamuri", "Marketing Assistant", "1900 Oak St.", "Vancouver", "BC", "V3F 2K1", "Canada", "(604) 555-3392", "(604) 555-7293", });
			table.Rows.Add(new object[] { "LAZYK", "Lazy K Kountry Store", "John Steel", "Marketing Manager", "12 Orchestra Terrace", "Walla Walla", "WA", "99362", "USA", "(509) 555-7969", "(509) 555-6221", });
			table.Rows.Add(new object[] { "LEHMS", "Lehmanns Marktstand", "Renate Messner", "Sales Representative", "Magazinweg 7", "Frankfurt a.M. ", null, "60528", "Germany", "069-0245984", "069-0245874", });
			table.Rows.Add(new object[] { "LETSS", "Let's Stop N Shop", "Jaime Yorres", "Owner", "87 Polk St.Suite 5", "San Francisco", "CA", "94117", "USA", "(415) 555-5938", null, });
			table.Rows.Add(new object[] { "LILAS", "LILA-Supermercado", "Carlos Gonzalez", "Accounting Manager", "Carrera 52 con Ave. Bolivar #65-98 Llano Largo", "Barquisimeto", "Lara", "3508", "Venezuela", "(9) 331-6954", "(9) 331-7256", });
			table.Rows.Add(new object[] { "LINOD", "LINO-Delicateses", "Felipe Izquierdo", "Owner", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "Nueva Esparta", "4980", "Venezuela", "(8) 34-56-12", "(8) 34-93-93", });
			table.Rows.Add(new object[] { "LONEP", "Lonesome Pine Restaurant", "Fran Wilson", "Sales Manager", "89 Chiaroscuro Rd.", "Portland", "OR", "97219", "USA", "(503) 555-9573", "(503) 555-9646", });
			table.Rows.Add(new object[] { "MAGAA", "Magazzini Alimentari Riuniti", "Giovanni Rovelli", "Marketing Manager", "Via Ludovico il Moro 22", "Bergamo", null, "24100", "Italy", "035-640230", "035-640231", });
			table.Rows.Add(new object[] { "MAISD", "Maison Dewey", "Catherine Dewey", "Sales Agent", "Rue Joseph-Bens 532", "Bruxelles", null, "B-1180", "Belgium", "(02) 201 24 67", "(02) 201 24 68", });
			table.Rows.Add(new object[] { "MEREP", "Mere Paillarde", "Jean Fresniere", "Marketing Assistant", "43 rue St. Laurent", "Montreal", "Quebec", "H1J 1C3", "Canada", "(514) 555-8054", "(514) 555-8055", });
			table.Rows.Add(new object[] { "MORGK", "Morgenstern Gesundkost", "Alexander Feuer", "Marketing Assistant", "Heerstr. 22", "Leipzig", null, "04179", "Germany", "0342-023176", null, });
			table.Rows.Add(new object[] { "NORTS", "North/South", "Simon Crowther", "Sales Associate", "South House300 Queensbridge", "London", null, "SW7 1RZ", "UK", "(171) 555-7733", "(171) 555-2530", });
			table.Rows.Add(new object[] { "OCEAN", "Oceano Atlantico Ltda.", "Yvonne Moncada", "Sales Agent", "Ing. Gustavo Moncada 8585Piso 20-A", "Buenos Aires", null, "1010", "Argentina", "(1) 135-5333", "(1) 135-5535", });
			table.Rows.Add(new object[] { "OLDWO", "Old World Delicatessen", "Rene Phillips", "Sales Representative", "2743 Bering St.", "Anchorage", "AK", "99508", "USA", "(907) 555-7584", "(907) 555-2880", });
			table.Rows.Add(new object[] { "OTTIK", "Ottilies Kaseladen", "Henriette Pfalzheim", "Owner", "Mehrheimerstr. 369", "Koln", null, "50739", "Germany", "0221-0644327", "0221-0765721", });
			table.Rows.Add(new object[] { "PARIS", "Paris specialites", "Marie Bertrand", "Owner", "265, boulevard Charonne", "Paris", null, "75012", "France", "(1) 42.34.22.66", "(1) 42.34.22.77", });
			table.Rows.Add(new object[] { "PERIC", "Pericles Comidas clasicas", "Guillermo Fernandez", "Sales Representative", "Calle Dr. Jorge Cash 321", "Mexico D.F.", null, "05033", "Mexico", "(5) 552-3745", "(5) 545-3745", });
			table.Rows.Add(new object[] { "PICCO", "Piccolo und mehr", "Georg Pipps", "Sales Manager", "Geislweg 14", "Salzburg", null, "5020", "Austria", "6562-9722", "6562-9723", });
			table.Rows.Add(new object[] { "PRINI", "Princesa Isabel Vinhos", "Isabel de Castro", "Sales Representative", "Estrada da saude n. 58", "Lisboa", null, "1756", "Portugal", "(1) 356-5634", null, });
			table.Rows.Add(new object[] { "QUEDE", "Que Delicia", "Bernardo Batista", "Accounting Manager", "Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil", "(21) 555-4252", "(21) 555-4545", });
			table.Rows.Add(new object[] { "QUEEN", "Queen Cozinha", "Lucia Carvalho", "Marketing Assistant", "Alameda dos Canarios, 891", "Sao Paulo", "SP", "05487-020", "Brazil", "(11) 555-1189", null, });
			table.Rows.Add(new object[] { "QUICK", "QUICK-Stop", "Horst Kloss", "Accounting Manager", "Taucherstrasse 10", "Cunewalde", null, "01307", "Germany", "0372-035188", null, });
			table.Rows.Add(new object[] { "RANCH", "Rancho grande", "Sergio Gutierrez", "Sales Representative", "Av. del Libertador 900", "Buenos Aires", null, "1010", "Argentina", "(1) 123-5555", "(1) 123-5556", });
			table.Rows.Add(new object[] { "RATTC", "Rattlesnake Canyon Grocery", "Paula Wilson", "Assistant Sales Representative", "2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA", "(505) 555-5939", "(505) 555-3620", });
			table.Rows.Add(new object[] { "REGGC", "Reggiani Caseifici", "Maurizio Moroni", "Sales Associate", "Strada Provinciale 124", "Reggio Emilia", null, "42100", "Italy", "0522-556721", "0522-556722", });
			table.Rows.Add(new object[] { "RICAR", "Ricardo Adocicados", "Janete Limeira", "Assistant Sales Agent", "Av. Copacabana, 267", "Rio de Janeiro", "RJ", "02389-890", "Brazil", "(21) 555-3412", null, });
			table.Rows.Add(new object[] { "RICSU", "Richter Supermarkt", "Michael Holz", "Sales Manager", "Grenzacherweg 237", "Geneve", null, "1203", "Switzerland", "0897-034214", null, });
			table.Rows.Add(new object[] { "ROMEY", "Romero y tomillo", "Alejandra Camino", "Accounting Manager", "Gran Via, 1", "Madrid", null, "28001", "Spain", "(91) 745 6200", "(91) 745 6210", });
			table.Rows.Add(new object[] { "SANTG", "Sante Gourmet", "Jonas Bergulfsen", "Owner", "Erling Skakkes gate 78", "Stavern", null, "4110", "Norway", "07-98 92 35", "07-98 92 47", });
			table.Rows.Add(new object[] { "SAVEA", "Save-a-lot Markets", "Jose Pavarotti", "Sales Representative", "187 Suffolk Ln.", "Boise", "ID", "83720", "USA", "(208) 555-8097", null, });
			table.Rows.Add(new object[] { "SEVES", "Seven Seas Imports", "Hari Kumar", "Sales Manager", "90 Wadhurst Rd.", "London", null, "OX15 4NB", "UK", "(171) 555-1717", "(171) 555-5646", });
			table.Rows.Add(new object[] { "SIMOB", "Simons bistro", "Jytte Petersen", "Owner", "Vinbaltet 34", "Kobenhavn", null, "1734", "Denmark", "31 12 34 56", "31 13 35 57", });
			table.Rows.Add(new object[] { "SPECD", "Specialites du monde", "Dominique Perrier", "Marketing Manager", "25, rue Lauriston", "Paris", null, "75016", "France", "(1) 47.55.60.10", "(1) 47.55.60.20", });
			table.Rows.Add(new object[] { "SPLIR", "Split Rail Beer & Ale", "Art Braunschweiger", "Sales Manager", "P.O. Box 555", "Lander", "WY", "82520", "USA", "(307) 555-4680", "(307) 555-6525", });
			table.Rows.Add(new object[] { "SUPRD", "Supremes delices", "Pascale Cartrain", "Accounting Manager", "Boulevard Tirou, 255", "Charleroi", null, "B-6000", "Belgium", "(071) 23 67 22 20", "(071) 23 67 22 21", });
			table.Rows.Add(new object[] { "THEBI", "The Big Cheese", "Liz Nixon", "Marketing Manager", "89 Jefferson WaySuite 2", "Portland", "OR", "97201", "USA", "(503) 555-3612", null, });
			table.Rows.Add(new object[] { "THECR", "The Cracker Box", "Liu Wong", "Marketing Assistant", "55 Grizzly Peak Rd.", "Butte", "MT", "59801", "USA", "(406) 555-5834", "(406) 555-8083", });
			table.Rows.Add(new object[] { "TOMSP", "Toms Spezialitaten", "Karin Josephs", "Marketing Manager", "Luisenstr. 48", "Munster", null, "44087", "Germany", "0251-031259", "0251-035695", });
			table.Rows.Add(new object[] { "TORTU", "Tortuga Restaurante", "Miguel Angel Paolino", "Owner", "Avda. Azteca 123", "Mexico D.F.", null, "05033", "Mexico", "(5) 555-2933", null, });
			table.Rows.Add(new object[] { "TRADH", "Tradicao Hipermercados", "Anabela Domingues", "Sales Representative", "Av. Ines de Castro, 414", "Sao Paulo", "SP", "05634-030", "Brazil", "(11) 555-2167", "(11) 555-2168", });
			table.Rows.Add(new object[] { "TRAIH", "Trail's Head Gourmet Provisioners", "Helvetius Nagy", "Sales Associate", "722 DaVinci Blvd.", "Kirkland", "WA", "98034", "USA", "(206) 555-8257", "(206) 555-2174", });
			table.Rows.Add(new object[] { "VAFFE", "Vaffeljernet", "Palle Ibsen", "Sales Manager", "Smagsloget 45", "erhus", null, "8200", "Denmark", "86 21 32 43", "86 22 33 44", });
			table.Rows.Add(new object[] { "VICTE", "Victuailles en stock", "Mary Saveley", "Sales Agent", "2, rue du Commerce", "Lyon", null, "69004", "France", "78.32.54.86", "78.32.54.87", });
			table.Rows.Add(new object[] { "VINET", "Vins et alcools Chevalier", "Paul Henriot", "Accounting Manager", "59 rue de l'Abbaye", "Reims", null, "51100", "France", "26.47.15.10", "26.47.15.11", });
			table.Rows.Add(new object[] { "WANDK", "Die Wandernde Kuh", "Rita Muller", "Sales Representative", "Adenauerallee 900", "Stuttgart", null, "70563", "Germany", "0711-020361", "0711-035428", });
			table.Rows.Add(new object[] { "WARTH", "Wartian Herkku", "Pirkko Koskitalo", "Accounting Manager", "Torikatu 38", "Oulu", null, "90110", "Finland", "981-443655", "981-443655", });
			table.Rows.Add(new object[] { "WELLI", "Wellington Importadora", "Paula Parente", "Sales Manager", "Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil", "(14) 555-8122", null, });
			table.Rows.Add(new object[] { "WHITC", "White Clover Markets", "Karl Jablonski", "Owner", "305 - 14th Ave. S.Suite 3B", "Seattle", "WA", "98128", "USA", "(206) 555-4112", "(206) 555-4115", });
			table.Rows.Add(new object[] { "WILMK", "Wilman Kala", "Matti Karttunen", "Owner/Marketing Assistant", "Keskuskatu 45", "Helsinki", null, "21240", "Finland", "90-224 8858", "90-224 8858", });
			table.Rows.Add(new object[] { "WOLZA", "Wolski  Zajazd", "Zbyszek Piestrzeniewicz", "Owner", "ul. Filtrowa 68", "Warszawa", null, "01-012", "Poland", "(26) 642-7012", "(26) 642-7012", });

			foreach (var row in table.Select(string.Format("Country <> '{0}'", this.Country.Value)))
				row.Delete();
		}
		private void ActiveReport_FetchData(object sender, FetchEventArgs eArgs)
		{

			if (counter == table.Rows.Count)
			{

				eArgs.EOF = true;
				return;

			}
			else
			{
				this.Fields["CustomerID"].Value = table.Rows[counter]["CustomerID"];
				this.Fields["CompanyName"].Value = table.Rows[counter]["CompanyName"];
				this.Fields["ContactName"].Value = table.Rows[counter]["ContactName"];
				this.Fields["ContactTitle"].Value = table.Rows[counter]["ContactTitle"];
				this.Fields["Address"].Value = table.Rows[counter]["Address"];
				this.Fields["City"].Value = table.Rows[counter]["City"];
				this.Fields["Region"].Value = table.Rows[counter]["Region"];
				this.Fields["PostalCode"].Value = table.Rows[counter]["PostalCode"];
				this.Fields["Country"].Value = table.Rows[counter]["Country"];
				this.Fields["Phone"].Value = table.Rows[counter]["Phone"];
				this.Fields["Fax"].Value = table.Rows[counter]["Fax"];
				counter++;
				eArgs.EOF = false;
			}
		}
	}
}