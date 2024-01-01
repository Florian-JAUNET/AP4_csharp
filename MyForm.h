#pragma once
#include "Homeform.h"
#include "FormHome.h"
#include "FormMoney.h"
#include "FormLogin.h"

#include <iostream>
#include <string>
#include <msclr/marshal_cppstd.h>
#include <Windows.h>
#include <msclr/marshal_cppstd.h>
#include <iostream>


namespace linkhubCLR {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	
#pragma region variable
	//variable
	char bonjour[] = "Hello";
	std::string prenom = "John";
	std::string uwu = "dad";


	
	
	//--------------------
#pragma endregion
	/// <summary>
	/// Description résumée de MyForm
	/// form de test et de base 
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
		
	public:
		Color hoverColor = Color::FromArgb(117, 162, 221);
		Color unhoverColor = Color::FromArgb(254, 254, 254);
		Color primaryColor = Color::FromArgb(0, 111, 253);
		Color netralColor = Color::FromArgb(254, 254, 254);
	private: System::Windows::Forms::Button^ btnMoney;
	private: System::Windows::Forms::Button^ btnProfil;
	public:


	public:



		Form^ activeForm = nullptr;
		MyForm(void)
		{
			
			InitializeComponent();
			//
			//TODO: ajoutez ici le code du constructeur
			//
		}
#pragma region pas_interesant



	protected:
		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^ panelMenu;
	private: System::Windows::Forms::Panel^ panelPrincipal;
	private: System::Windows::Forms::Button^ button1;



	private: System::Windows::Forms::ImageList^ imageList1;
	private: System::Windows::Forms::PictureBox^ pictureBox1;
	private: System::ComponentModel::IContainer^ components;


	protected:

	protected:

	protected:

	protected:

	protected:



	protected:

	private:
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>

#pragma endregion
#pragma region Windows Form Designer generated code
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(MyForm::typeid));
			this->panelMenu = (gcnew System::Windows::Forms::Panel());
			this->btnProfil = (gcnew System::Windows::Forms::Button());
			this->imageList1 = (gcnew System::Windows::Forms::ImageList(this->components));
			this->btnMoney = (gcnew System::Windows::Forms::Button());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->panelPrincipal = (gcnew System::Windows::Forms::Panel());
			this->panelMenu->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// panelMenu
			// 
			this->panelMenu->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(241)), static_cast<System::Int32>(static_cast<System::Byte>(241)),
				static_cast<System::Int32>(static_cast<System::Byte>(241)));
			this->panelMenu->Controls->Add(this->btnProfil);
			this->panelMenu->Controls->Add(this->btnMoney);
			this->panelMenu->Controls->Add(this->pictureBox1);
			this->panelMenu->Controls->Add(this->button1);
			this->panelMenu->Dock = System::Windows::Forms::DockStyle::Top;
			this->panelMenu->Location = System::Drawing::Point(0, 0);
			this->panelMenu->Name = L"panelMenu";
			this->panelMenu->Size = System::Drawing::Size(1282, 68);
			this->panelMenu->TabIndex = 1;
			this->panelMenu->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &MyForm::panelMenu_Paint);
			// 
			// btnProfil
			// 
			this->btnProfil->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->btnProfil->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnProfil->FlatAppearance->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnProfil->FlatAppearance->MouseDownBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnProfil->FlatAppearance->MouseOverBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnProfil->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnProfil->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(8)), static_cast<System::Int32>(static_cast<System::Byte>(8)),
				static_cast<System::Int32>(static_cast<System::Byte>(8)));
			this->btnProfil->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnProfil->ImageIndex = 0;
			this->btnProfil->ImageList = this->imageList1;
			this->btnProfil->Location = System::Drawing::Point(384, 12);
			this->btnProfil->Name = L"btnProfil";
			this->btnProfil->Size = System::Drawing::Size(118, 50);
			this->btnProfil->TabIndex = 4;
			this->btnProfil->Text = L"Profil";
			this->btnProfil->UseVisualStyleBackColor = false;
			this->btnProfil->Click += gcnew System::EventHandler(this, &MyForm::btnProfil_Click);
			// 
			// imageList1
			// 
			this->imageList1->ImageStream = (cli::safe_cast<System::Windows::Forms::ImageListStreamer^>(resources->GetObject(L"imageList1.ImageStream")));
			this->imageList1->TransparentColor = System::Drawing::Color::Transparent;
			this->imageList1->Images->SetKeyName(0, L"settings.png");
			this->imageList1->Images->SetKeyName(1, L"home.png");
			this->imageList1->Images->SetKeyName(2, L"eye-crossed.png");
			this->imageList1->Images->SetKeyName(3, L"trash.png");
			this->imageList1->Images->SetKeyName(4, L"refresh.png");
			this->imageList1->Images->SetKeyName(5, L"angle-small-down.png");
			this->imageList1->Images->SetKeyName(6, L"shopping-cart.png");
			this->imageList1->Images->SetKeyName(7, L"users-alt.png");
			this->imageList1->Images->SetKeyName(8, L"menu-burger.png");
			// 
			// btnMoney
			// 
			this->btnMoney->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->btnMoney->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnMoney->FlatAppearance->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnMoney->FlatAppearance->MouseDownBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnMoney->FlatAppearance->MouseOverBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->btnMoney->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->btnMoney->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(8)), static_cast<System::Int32>(static_cast<System::Byte>(8)),
				static_cast<System::Int32>(static_cast<System::Byte>(8)));
			this->btnMoney->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->btnMoney->ImageIndex = 6;
			this->btnMoney->ImageList = this->imageList1;
			this->btnMoney->Location = System::Drawing::Point(260, 12);
			this->btnMoney->Name = L"btnMoney";
			this->btnMoney->Size = System::Drawing::Size(118, 50);
			this->btnMoney->TabIndex = 3;
			this->btnMoney->Text = L"Wallet";
			this->btnMoney->UseVisualStyleBackColor = false;
			this->btnMoney->Click += gcnew System::EventHandler(this, &MyForm::btnMoney_Click);
			this->btnMoney->MouseEnter += gcnew System::EventHandler(this, &MyForm::btnMoney_MouseEnter);
			this->btnMoney->MouseLeave += gcnew System::EventHandler(this, &MyForm::btnMoney_MouseLeave);
			// 
			// pictureBox1
			// 
			this->pictureBox1->BackgroundImage = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox1.BackgroundImage")));
			this->pictureBox1->BackgroundImageLayout = System::Windows::Forms::ImageLayout::Zoom;
			this->pictureBox1->Location = System::Drawing::Point(12, 12);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(118, 50);
			this->pictureBox1->TabIndex = 2;
			this->pictureBox1->TabStop = false;
			// 
			// button1
			// 
			this->button1->Anchor = System::Windows::Forms::AnchorStyles::Top;
			this->button1->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->button1->FlatAppearance->BorderColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->button1->FlatAppearance->MouseDownBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->button1->FlatAppearance->MouseOverBackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(254)),
				static_cast<System::Int32>(static_cast<System::Byte>(254)), static_cast<System::Int32>(static_cast<System::Byte>(254)));
			this->button1->FlatStyle = System::Windows::Forms::FlatStyle::Flat;
			this->button1->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(8)), static_cast<System::Int32>(static_cast<System::Byte>(8)),
				static_cast<System::Int32>(static_cast<System::Byte>(8)));
			this->button1->ImageAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->button1->ImageIndex = 1;
			this->button1->ImageList = this->imageList1;
			this->button1->Location = System::Drawing::Point(136, 12);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(118, 50);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Home";
			this->button1->UseVisualStyleBackColor = false;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click_1);
			this->button1->MouseEnter += gcnew System::EventHandler(this, &MyForm::button1_MouseEnter);
			this->button1->MouseLeave += gcnew System::EventHandler(this, &MyForm::button1_MouseLeave);
			this->button1->MouseHover += gcnew System::EventHandler(this, &MyForm::button1_MouseHover);
			// 
			// panelPrincipal
			// 
			this->panelPrincipal->Dock = System::Windows::Forms::DockStyle::Fill;
			this->panelPrincipal->Location = System::Drawing::Point(0, 68);
			this->panelPrincipal->Name = L"panelPrincipal";
			this->panelPrincipal->Size = System::Drawing::Size(1282, 605);
			this->panelPrincipal->TabIndex = 2;
			this->panelPrincipal->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &MyForm::panelPrincipal_Paint);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::Window;
			this->ClientSize = System::Drawing::Size(1282, 673);
			this->Controls->Add(this->panelPrincipal);
			this->Controls->Add(this->panelMenu);
			this->Font = (gcnew System::Drawing::Font(L"Arial", 7.8F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->panelMenu->ResumeLayout(false);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion


	public: System::Void openChildForm(Form^ formEnfant) {
		if (activeForm != nullptr)
			activeForm->Close();
		activeForm = formEnfant;
		formEnfant->TopLevel = false;
		formEnfant->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
		formEnfant->Dock = DockStyle::Fill;
		panelPrincipal->Controls->Add(formEnfant);
		panelPrincipal->Tag = formEnfant;
		formEnfant->BringToFront();
		formEnfant->Show();

	}
	public: System::Void resetColorButton() {
		button1->FlatAppearance->BorderColor = netralColor;
		btnMoney->FlatAppearance->BorderColor = netralColor;
		btnProfil->FlatAppearance->BorderColor = netralColor;


	}

	public: System::Void changeSelectedButton(Button^ buttonSelected) {
		resetColorButton();
		buttonSelected->FlatAppearance->BorderColor = primaryColor;

	}
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {

	}
	private: System::Void MyForm_Load(System::Object^ sender, System::EventArgs^ e) {

	}
	private: System::Void button1_Click_1(System::Object^ sender, System::EventArgs^ e) {
		changeSelectedButton(button1);
		openChildForm(gcnew linkhubCLR::FormHome);
	}
private: System::Void panelMenu_Paint(System::Object^ sender, System::Windows::Forms::PaintEventArgs^ e) {
}
private: System::Void button1_MouseHover(System::Object^ sender, System::EventArgs^ e) {
	
	if (button1->FlatAppearance->BorderColor != primaryColor){
		button1->FlatAppearance->BorderColor = hoverColor;
	}
}
private: System::Void button1_MouseLeave(System::Object^ sender, System::EventArgs^ e) {
	if (button1->FlatAppearance->BorderColor != primaryColor){
		button1->FlatAppearance->BorderColor = unhoverColor;
	}

}
private: System::Void button1_MouseEnter(System::Object^ sender, System::EventArgs^ e) {
	if (button1->FlatAppearance->BorderColor != primaryColor){ 
		button1->FlatAppearance->BorderColor = hoverColor;
	}

}
private: System::Void btnMoney_Click(System::Object^ sender, System::EventArgs^ e) {
	changeSelectedButton(btnMoney);
	openChildForm(gcnew linkhubCLR::FormMoney);
}
private: System::Void btnProfil_Click(System::Object^ sender, System::EventArgs^ e) {
	changeSelectedButton(btnProfil);
	openChildForm(gcnew linkhubCLR::FormLogin);


}
private: System::Void btnMoney_MouseEnter(System::Object^ sender, System::EventArgs^ e) {
	if (btnMoney->FlatAppearance->BorderColor != primaryColor) {
		btnMoney->FlatAppearance->BorderColor = hoverColor;
	}
}
private: System::Void btnMoney_MouseLeave(System::Object^ sender, System::EventArgs^ e) {
	if (btnMoney->FlatAppearance->BorderColor != primaryColor) {
		btnMoney->FlatAppearance->BorderColor = unhoverColor;
	}
}
private: System::Void panelPrincipal_Paint(System::Object^ sender, System::Windows::Forms::PaintEventArgs^ e) {
}
};
}
