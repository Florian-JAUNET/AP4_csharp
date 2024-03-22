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
	/// Description résumée de FormMoney
	/// </summary>
	public ref class FormMoney : public System::Windows::Forms::Form
	{
	private:
		ManagedDatabaseConnector^ managedConnector;
	public:
		ref class MyData {
		public:
			String^ id;
			String^ text;
		};
		FormMoney(void)
		{
			InitializeComponent();

			managedConnector = gcnew ManagedDatabaseConnector();
			//
			//TODO: ajoutez ici le code du constructeur
			//
		}
	private:
		array<MyData^>^ dataArray;

	protected:
		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		~FormMoney()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ComboBox^ cbListUser;
	private: System::Windows::Forms::GroupBox^ groupBox1;
	private: System::Windows::Forms::TextBox^ tbSomme;

	private: System::Windows::Forms::Button^ BtnPaye;



	protected:


	protected:

	private:
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		void InitializeComponent(void)
		{
			this->cbListUser = (gcnew System::Windows::Forms::ComboBox());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->tbSomme = (gcnew System::Windows::Forms::TextBox());
			this->BtnPaye = (gcnew System::Windows::Forms::Button());
			this->groupBox1->SuspendLayout();
			this->SuspendLayout();
			// 
			// cbListUser
			// 
			this->cbListUser->Font = (gcnew System::Drawing::Font(L"Sans Serif Collection", 7.8F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->cbListUser->FormattingEnabled = true;
			this->cbListUser->Location = System::Drawing::Point(12, 12);
			this->cbListUser->Name = L"cbListUser";
			this->cbListUser->Size = System::Drawing::Size(367, 40);
			this->cbListUser->TabIndex = 0;
			this->cbListUser->SelectedIndexChanged += gcnew System::EventHandler(this, &FormMoney::cbListUser_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this->groupBox1->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom));
			this->groupBox1->BackColor = System::Drawing::SystemColors::Menu;
			this->groupBox1->Controls->Add(this->tbSomme);
			this->groupBox1->Font = (gcnew System::Drawing::Font(L"Arial", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->groupBox1->Location = System::Drawing::Point(408, 12);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(479, 544);
			this->groupBox1->TabIndex = 1;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Payer la somme";
			// 
			// tbSomme
			// 
			this->tbSomme->Font = (gcnew System::Drawing::Font(L"Sans Serif Collection", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->tbSomme->Location = System::Drawing::Point(88, 241);
			this->tbSomme->Name = L"tbSomme";
			this->tbSomme->Size = System::Drawing::Size(297, 57);
			this->tbSomme->TabIndex = 0;
			// 
			// BtnPaye
			// 
			this->BtnPaye->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Bottom | System::Windows::Forms::AnchorStyles::Right));
			this->BtnPaye->Font = (gcnew System::Drawing::Font(L"Sans Serif Collection", 13.8F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->BtnPaye->Location = System::Drawing::Point(1043, 500);
			this->BtnPaye->Name = L"BtnPaye";
			this->BtnPaye->Size = System::Drawing::Size(208, 93);
			this->BtnPaye->TabIndex = 2;
			this->BtnPaye->Text = L"Payer";
			this->BtnPaye->UseVisualStyleBackColor = true;
			this->BtnPaye->Click += gcnew System::EventHandler(this, &FormMoney::BtnPaye_Click);
			// 
			// FormMoney
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::Window;
			this->ClientSize = System::Drawing::Size(1282, 605);
			this->Controls->Add(this->BtnPaye);
			this->Controls->Add(this->groupBox1);
			this->Controls->Add(this->cbListUser);
			this->Font = (gcnew System::Drawing::Font(L"Arial", 7.8F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Name = L"FormMoney";
			this->Text = L"FormMoney";
			this->Load += gcnew System::EventHandler(this, &FormMoney::FormMoney_Load);
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void FormMoney_Load(System::Object^ sender, System::EventArgs^ e) {
		managedConnector->ConnectDb("192.168.114.2", "lmascher", "hJfmd@$#w2@sBQYV", "linkhub");
		sql::ResultSet* result = managedConnector->GetUserAll();

		std::vector<std::string> dataList;
		std::map<std::string, std::string> idTextMap;
		//compte le nombre denregistrement de getUser en bdd
		int cptEntreUser = 0;

		// Parcours des résultats et ajout à la combolist avec l'ID caché dans la map
		while (result->next()) {
			std::string id = result->getString(1); // Supposons que l'ID soit dans la première colonne
			std::string text = result->getString(2) + "-" + result->getString(3); // Supposons que le texte soit dans la deuxième colonne

			dataList.push_back(text);
			idTextMap[id] = text; // Stocke la correspondance ID <-> Texte dans la map
			cptEntreUser++;
		}
		//ajustattion du tableau par rapport au nb denregistrement
		dataArray = gcnew array<MyData^>(cptEntreUser);
		cptEntreUser = 0;
		result = managedConnector->GetUserAll();
		// Ajoute des données au tableau
		while (result->next()) {

			std::string id = result->getString(1); // Supposons que l'ID soit dans la première colonne
			std::string text = result->getString(2) + "-" + result->getString(3); // Supposons que le texte soit dans la deuxième colonne
			//convertion en type systeme
			System::String^ managedText = gcnew System::String(text.c_str());
			System::String^ managedId = gcnew System::String(id.c_str());


			// Ajoute des données au tableau
			dataArray[cptEntreUser] = gcnew MyData();
			dataArray[cptEntreUser]->id = managedId;
			dataArray[cptEntreUser]->text = managedText;

			cptEntreUser++;
		}

		// Parcours de la dataList pour ajouter les éléments à la combolist
		for (const auto& text : dataList) {
			cbListUser->Items->Add(gcnew String(text.c_str()));
		}
	}

	private: System::Void cbListUser_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e) {
	}
	private: System::Void BtnPaye_Click(System::Object^ sender, System::EventArgs^ e) {
		
		int indexSelectionne = cbListUser->SelectedIndex;
		System::String^ ttSomme = tbSomme->Text;
		System::String^ managedString = dataArray[indexSelectionne]->id;
		std::string nativeString = msclr::interop::marshal_as<std::string>(managedString);
		managedConnector->ConnectDb("192.168.114.2", "lmascher", "hJfmd@$#w2@sBQYV", "linkhub");
		bool result = managedConnector->AlterSommeUserAdd("4","56");

	}
};
}


