#pragma once
#include "managedDatabase.h"
#include <string>
#include <iostream>
#include <vector> // Import du header pour std::vector
#include <string> // Import du header pour std::string
#include "mysql_connection.h"



namespace linkhubCLR {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;




	/// <summary>
	/// Description r�sum�e de FormMoney
	/// </summary>
	public ref class FormMoney : public System::Windows::Forms::Form
	{
	private:
		ManagedDatabaseConnector^ managedConnector;
	public:
		FormMoney(void)
		{
			InitializeComponent();

			managedConnector = gcnew ManagedDatabaseConnector();
			//
			//TODO: ajoutez ici le code du constructeur
			//
		}

	protected:
		/// <summary>
		/// Nettoyage des ressources utilis�es.
		/// </summary>
		~FormMoney()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ComboBox^ cbListUser;
		   


	protected:


	protected:

	private:
		/// <summary>
		/// Variable n�cessaire au concepteur.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// M�thode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette m�thode avec l'�diteur de code.
		/// </summary>
		void InitializeComponent(void)
		{
			this->cbListUser = (gcnew System::Windows::Forms::ComboBox());
			this->SuspendLayout();
			// 
			// cbListUser
			// 
			this->cbListUser->FormattingEnabled = true;
			this->cbListUser->Location = System::Drawing::Point(12, 12);
			this->cbListUser->Name = L"cbListUser";
			this->cbListUser->Size = System::Drawing::Size(367, 24);
			this->cbListUser->TabIndex = 0;
			this->cbListUser->SelectedIndexChanged += gcnew System::EventHandler(this, &FormMoney::cbListUser_SelectedIndexChanged);
			// 
			// FormMoney
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::Window;
			this->ClientSize = System::Drawing::Size(1282, 605);
			this->Controls->Add(this->cbListUser);
			this->Font = (gcnew System::Drawing::Font(L"Arial", 7.8F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Name = L"FormMoney";
			this->Text = L"FormMoney";
			this->Load += gcnew System::EventHandler(this, &FormMoney::FormMoney_Load);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void FormMoney_Load(System::Object^ sender, System::EventArgs^ e) {
		managedConnector->ConnectDb("192.168.114.2", "lmascher", "hJfmd@$#w2@sBQYV", "linkhub");
		sql::ResultSet* result = managedConnector->GetUserModerateur();

		std::vector<std::string> dataList;
		std::map<std::string, std::string> idTextMap;

		// Parcours des r�sultats et ajout � la combolist avec l'ID cach� dans la map
		while (result->next()) {
			std::string id = result->getString(1); // Supposons que l'ID soit dans la premi�re colonne
			std::string text = result->getString(2) + "-" + result->getString(3); // Supposons que le texte soit dans la deuxi�me colonne

			dataList.push_back(text);
			idTextMap[id] = text; // Stocke la correspondance ID <-> Texte dans la map
		}

		// Parcours de la dataList pour ajouter les �l�ments � la combolist
		for (const auto& text : dataList) {
			cbListUser->Items->Add(gcnew String(text.c_str()));
		}
	}

	private: System::Void cbListUser_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e) {
	}
	};
}


