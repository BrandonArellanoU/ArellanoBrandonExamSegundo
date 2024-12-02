namespace ArellanoBrandonExamSegundo.Views;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

        LoadNote(Path.Combine(appDataPath, randomFileName));

    }

    private async void Guardar_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Page1 numero)
            File.WriteAllText(TexNombre.file, TextEditorNumero.Text);
            File.WriteAllText(nombre.file, TextEditorNombre.Text);

        await Shell.Current.GoToAsync("..");
    }


    private void LoadNote(string fileName)
    {
        Models.Page1 text = new Models.Page1;
        text.file = fileName;

        if (File.Exists(fileName))
        {
            noteModel.Date = File.GetCreationTime(fileName);
            noteModel.Text = File.ReadAllText(fileName);
        }

        BindingContext = noteModel;
    }
}