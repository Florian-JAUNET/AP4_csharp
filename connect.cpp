#include <iostream>
#include "mysql_connection.h"
#include <cppconn/driver.h>
#include <cppconn/exception.h>
#include <cppconn/prepared_statement.h>



class DatabaseConnector {
private:
	sql::Driver *driver;
	sql::Connection *con;
	sql::Statement *stmt;
	sql::PreparedStatement *pstmt;
	sql::ResultSet* resultRq;

public:
	
	void connectDb(std::string server, std::string username, std::string mdp, std::string database) {
		try
		{
			driver = get_driver_instance();
			con = driver->connect(server, username, mdp);
			con->setSchema(database);
			printf("bdd connecte");
		}
		catch (sql::SQLException e)
		{
			printf("aucun connection a la base de donnes");
			/*system("pause");
			exit(1);*/
		}
	}

	sql::ResultSet* DatabaseConnector::getAuteur(int idAut) {
		try
		{

			pstmt = con->prepareStatement("SELECT * FROM AUTEUR WHERE ID = ? ORDER BY id ASC");
			pstmt->setInt(1, idAut);
			resultRq = pstmt->executeQuery();
			delete pstmt;
			return resultRq;
		}
	
		catch (sql::SQLException& e) {return nullptr;}
		catch (std::exception& e) {return nullptr;}
		return nullptr;

			
	}

	sql::ResultSet* DatabaseConnector::getAuteurAll() {
		try
		{
			pstmt = con->prepareStatement("SELECT * FROM AUTEUR ORDER BY id ASC");
			resultRq = pstmt->executeQuery();
			delete pstmt;
			return resultRq;
		}

		catch (sql::SQLException& e) { return nullptr; }
		catch (std::exception& e) { return nullptr; }
		return nullptr;


	}

	bool TestConnectAdmin(std::string id,std::string mdp) {
		return false;
	}
	bool alterSommeUserAdd(std::string id , std::string somme) {
		
		try
		{

			pstmt = con->prepareStatement("UPDATE UTILISATEUR SET Wallet = ? + Wallet WHERE UTILISATEUR.ID_USER = ?;");
			pstmt->setString(1, somme);
			pstmt->setString(1, id);
			resultRq = pstmt->executeQuery();
			delete pstmt;
			return true;
		}

		catch (sql::SQLException& e) { return false; }
		catch (std::exception& e) { return false; }
		return false;
	}
	
	sql::ResultSet* DatabaseConnector::getUserModerateur() {
		try
		{

			pstmt = con->prepareStatement("SELECT* FROM UTILISATEUR WHERE MODERATEUR = 1;");
			resultRq = pstmt->executeQuery();
			delete pstmt;
			return resultRq;
		}

		catch (sql::SQLException& e) { return nullptr; }
		catch (std::exception& e) { return nullptr; }
		return nullptr;


	}
	sql::ResultSet* DatabaseConnector::getUserAll() {
		try
		{

			pstmt = con->prepareStatement("SELECT* FROM UTILISATEUR;");
			resultRq = pstmt->executeQuery();
			delete pstmt;
			return resultRq;
		}

		catch (sql::SQLException& e) { return nullptr; }
		catch (std::exception& e) { return nullptr; }
		return nullptr;


	}


	


};

/*
int uwu() {



	
	//please create database "quickstartdb" ahead of time
	con->setSchema("quickstartdb");

	stmt = con->createStatement();
	stmt->execute("DROP TABLE IF EXISTS inventory");
	cout << "Finished dropping table (if existed)" << endl;
	stmt->execute("CREATE TABLE inventory (id serial PRIMARY KEY, name VARCHAR(50), quantity INTEGER);");
	cout << "Finished creating table" << endl;
	delete stmt;

	pstmt = con->prepareStatement("INSERT INTO inventory(name, quantity) VALUES(?,?)");
	pstmt->setString(1, "banana");
	pstmt->setInt(2, 150);
	pstmt->execute();
	cout << "One row inserted." << endl;

	pstmt->setString(1, "orange");
	pstmt->setInt(2, 154);
	pstmt->execute();
	cout << "One row inserted." << endl;

	pstmt->setString(1, "apple");
	pstmt->setInt(2, 100);
	pstmt->execute();
	cout << "One row inserted." << endl;

	delete pstmt;
	delete con;
	system("pause");
	return 0;
	

}
*/