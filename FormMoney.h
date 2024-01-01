#pragma once


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
	public:
		FormMoney(void)
		{
			InitializeComponent();


			//
			//TODO: ajoutez ici le code du constructeur
			//
		}

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
		

		
	}
	};
}
