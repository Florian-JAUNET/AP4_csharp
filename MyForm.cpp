#include "MyForm.h"
#include "Homeform.h"
#include "HomeForm.h"
#include "FormMoney.h"

#include <Windows.h>
#include "MyForm.h" // Remplacez par le nom réel de votre formulaire

using namespace System;
using namespace System::Windows::Forms;


[STAThreadAttribute]
int main(array<String^>^ args) {
    Application::SetCompatibleTextRenderingDefault(false);
    Application::EnableVisualStyles();
    

    // Remplacez VotreFormulaire par le nom réel de votre formulaire
    linkhubCLR::MyForm form;
    Application::Run(% form);

    return 0;

}