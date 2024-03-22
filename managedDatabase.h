#pragma once
#pragma once

#include <msclr/marshal_cppstd.h>

#include "connect.cpp"

using namespace System;
using namespace System::Runtime::InteropServices;

public ref class ManagedDatabaseConnector {
private:
    DatabaseConnector* nativeConnector;

public:
    ManagedDatabaseConnector() {
        nativeConnector = new DatabaseConnector();
    }

    ~ManagedDatabaseConnector() {
        delete nativeConnector;
    }

    void ConnectDb(String^ server, String^ username, String^ mdp, String^ database) {
        nativeConnector->connectDb(msclr::interop::marshal_as<std::string>(server),
            msclr::interop::marshal_as<std::string>(username),
            msclr::interop::marshal_as<std::string>(mdp),
            msclr::interop::marshal_as<std::string>(database));
    }

    // Ajoutez d'autres méthodes d'enveloppe ici
    // ...

    sql::ResultSet* GetAuteur(int idAut) {
        return nativeConnector->getAuteur(idAut);
    }

    sql::ResultSet* GetAuteurAll() {
        return nativeConnector->getAuteurAll();
    }
    sql::ResultSet* GetUserAll() {
        return nativeConnector->getUserAll();
    }

    bool TestConnectAdmin(String^ id, String^ mdp) {
        return nativeConnector->TestConnectAdmin(msclr::interop::marshal_as<std::string>(id),
            msclr::interop::marshal_as<std::string>(mdp));
    }
    bool AlterSommeUserAdd(String^ id, String^ somme) {
        return nativeConnector->alterSommeUserAdd(msclr::interop::marshal_as<std::string>(id),
            msclr::interop::marshal_as<std::string>(somme));
    }

    sql::ResultSet* GetUserModerateur() {
        return nativeConnector->getUserModerateur();
    }
};
