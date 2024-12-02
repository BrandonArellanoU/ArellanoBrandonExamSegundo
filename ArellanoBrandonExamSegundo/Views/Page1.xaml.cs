namespace ArellanoBrandonExamSegundo.Views;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
    }

    private async void Guardar_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Page1 Page1)
            File.WriteAllText(TextEditor.Text, TextEditorNombre.Text);
          
        await Shell.Current.GoToAsync("..");
    }
}