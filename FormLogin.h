#pragma once

#include <msclr/marshal_cppstd.h>
#include "managedDatabase.h"

namespace linkhubCLR {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	
	

	/// <summary>
	/// Description résumée de FormLogin
	/// </summary>
	public ref class FormLogin : public System::Windows::Forms::Form
	{
	private:
		ManagedDatabaseConnector^ managedConnector;
	public:
		FormLogin(void)
		{
			InitializeComponent();

			managedConnector = gcnew ManagedDatabaseConnector();

			//
			//TODO: ajoutez ici le code du constructeur
			//
		}

	protected:
		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		~FormLogin()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::RichTextBox^ tbLogin;
	private: System::Windows::Forms::Panel^ panelMenu;
	private: System::Windows::Forms::RichTextBox^ tbMdp;
	private: System::Windows::Forms::Button^ btnConnexion;
	private: System::Windows::Forms::PictureBox^ pictureBox1;
	private: System::Windows::Forms::Panel^ panelRight;

	private: System::Windows::Forms::PictureBox^ pictureBox2;

	protected:

	protected:

	private:
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(FormLogin::typeid));
			this->tbLogin = (gcnew System::Windows::Forms::RichTextBox());
			this->panelMenu = (gcnew System::Windows::Forms::Panel());
			this->pictureBox2 = (gcnew System::Windows::Forms::PictureBox());
			this->btnConnexion = (gcnew System::Windows::Forms::Button());
			this->tbMdp = (gcnew System::Windows::Forms::RichTextBox());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->panelRight = (gcnew System::Windows::Forms::Panel());
			this->panelMenu->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox2))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// tbLogin
			// 
			this->tbLogin->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->tbLogin->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->tbLogin->Font = (gcnew System::Drawing::Font(L"Arial", 28.2F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->tbLogin->Location = System::Drawing::Point(29, 210);
			this->tbLogin->Multiline = false;
			this->tbLogin->Name = L"tbLogin";
			this->tbLogin->ScrollBars = System::Windows::Forms::RichTextBoxScrollBars::None;
			this->tbLogin->Size = System::Drawing::Size(623, 67);
			this->tbLogin->TabIndex = 0;
			this->tbLogin->Text = L"";
			// 
			// panelMenu
			// 
			this->panelMenu->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(241)), static_cast<System::Int32>(static_cast<System::Byte>(241)),
				static_cast<System::Int32>(static_cast<System::Byte>(241)));
			this->panelMenu->Controls->Add(this->pictureBox2);
			this->panelMenu->Controls->Add(this->btnConnexion);
			this->panelMenu->Controls->Add(this->tbMdp);
			this->panelMenu->Controls->Add(this->tbLogin);
			this->panelMenu->Dock = System::Windows::Forms::DockStyle::Left;
			this->panelMenu->Location = System::Drawing::Point(0, 0);
			this->panelMenu->Name = L"panelMenu";
			this->panelMenu->Size = System::Drawing::Size(680, 605);
			this->panelMenu->TabIndex = 2;
			// 
			// pictureBox2
			// 
			this->pictureBox2->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox2.Image")));
			this->pictureBox2->Location = System::Drawing::Point(29, 78);
			this->pictureBox2->Name = L"pictureBox2";
			this->pictureBox2->Size = System::Drawing::Size(623, 50);
			this->pictureBox2->SizeMode = System::Windows::Forms::PictureBoxSizeMode::CenterImage;
			this->pictureBox2->TabIndex = 5;
			this->pictureBox2->TabStop = false;
			// 
			// btnConnexion
			// 
			this->btnConnexion->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->btnConnexion->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnConnexion->FlatAppearance->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnConnexion->FlatAppearance->MouseDownBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(210)),
				static_cast<System::Int32>(static_cast<System::Byte>(234)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnConnexion->FlatAppearance->MouseOverBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(248)),
				static_cast<System::Int32>(static_cast<System::Byte>(248)), static_cast<System::Int32>(static_cast<System::Byte>(248)));
			this->btnConnexion->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnConnexion->Font = (gcnew System::Drawing::Font(L"Arial", 28.2F, System::Drawing::FontStyle::Bold));
			this->btnConnexion->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(8)), static_cast<System::Int32>(static_cast<System::Byte>(8)),
				static_cast<System::Int32>(static_cast<System::Byte>(8)));
			this->btnConnexion->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnConnexion->ImageIndex = 1;
			this->btnConnexion->Location = System::Drawing::Point(29, 457);
			this->btnConnexion->Name = L"btnConnexion";
			this->btnConnexion->Size = System::Drawing::Size(623, 85);
			this->btnConnexion->TabIndex = 3;
			this->btnConnexion->Text = L"Connexion";
			this->btnConnexion->UseVisualStyleBackColor = false;
			this->btnConnexion->Click += gcnew System::EventHandler(this, &FormLogin::btnConnexion_Click);
			// 
			// tbMdp
			// 
			this->tbMdp->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->tbMdp->Font = (gcnew System::Drawing::Font(L"Arial", 28.2F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->tbMdp->Location = System::Drawing::Point(29, 325);
			this->tbMdp->Multiline = false;
			this->tbMdp->Name = L"tbMdp";
			this->tbMdp->ScrollBars = System::Windows::Forms::RichTextBoxScrollBars::None;
			this->tbMdp->Size = System::Drawing::Size(623, 67);
			this->tbMdp->TabIndex = 1;
			this->tbMdp->Text = L"";
			this->tbMdp->TextChanged += gcnew System::EventHandler(this, &FormLogin::richTextBox1_TextChanged);
			// 
			// pictureBox1
			// 
			this->pictureBox1->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->pictureBox1->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox1.Image")));
			this->pictureBox1->Location = System::Drawing::Point(699, 231);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(571, 161);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox1->TabIndex = 3;
			this->pictureBox1->TabStop = false;
			// 
			// panelRight
			// 
			this->panelRight->Dock = System::Windows::Forms::DockStyle::Right;
			this->panelRight->Location = System::Drawing::Point(686, 0);
			this->panelRight->Name = L"panelRight";
			this->panelRight->Size = System::Drawing::Size(596, 605);
			this->panelRight->TabIndex = 4;
			this->panelRight->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &FormLogin::panelRight_Paint);
			// 
			// FormLogin
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::Window;
			this->ClientSize = System::Drawing::Size(1282, 605);
			this->Controls->Add(this->pictureBox1);
			this->Controls->Add(this->panelMenu);
			this->Controls->Add(this->panelRight);
			this->Font = (gcnew System::Drawing::Font(L"Arial", 7.8F, System::Drawing::FontStyle::Bold));
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Name = L"FormLogin";
			this->Text = L"FormLogin";
			this->panelMenu->ResumeLayout(false);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox2))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void richTextBox1_TextChanged(System::Object^ sender, System::EventArgs^ e) {
	}
	private: System::Void btnConnexion_Click(System::Object^ sender, System::EventArgs^ e) {
		/*DatabaseConnector dbConnect;
		dbConnect.connectDb("192.168.114.2", "lmascher", "hJfmd@$#w2@sBQYV","linkhub");
		int idAuteur = 30;  // Remplacez 1 par l'ID de l'auteur souhaité
		sql::ResultSet* result = dbConnect.getAuteur(idAuteur);

		if (result != nullptr && result->next()) {
			// Récupérer le nom de l'auteur depuis le résultat
			std::string nomAuteur = result->getString("NOM");
			System::String^ nomAuteurSys = msclr::interop::marshal_as<System::String^>(nomAuteur);
			tbLogin->Text = nomAuteurSys;
		}
		else {
			printf("rien");
		}*/
		managedConnector->ConnectDb("192.168.114.2", "lmascher", "hJfmd@$#w2@sBQYV", "linkhub");
		sql::ResultSet* result = managedConnector->GetAuteur(30);
		if (result != nullptr && result->next()) {
			// Récupérer le nom de l'auteur depuis le résultat
			std::string nomAuteur = result->getString("NOM");
			System::String^ nomAuteurSys = msclr::interop::marshal_as<System::String^>(nomAuteur);
			tbLogin->Text = nomAuteurSys;
		}
		else {
			printf("rien");
		}
	}
private: System::Void panelRight_Paint(System::Object^ sender, System::Windows::Forms::PaintEventArgs^ e) {
}
};
}
