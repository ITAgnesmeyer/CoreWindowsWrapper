# CoreWindowsWrapper
### Native Windows Wrapper for .NET-Core

CoreWindowsWrapper is a DLL you can use to create Core Applications showing Dialogs without using System.Windows.Forms.
The Project uses the Windows - API to create Native Windows. I personally use this DLL to create Copy-Deploy-Setups.

This is a Visual Stuido 2019 Preview Project using NETCore 3.0-preiew.
With NETCore 3.0 you can create Windows-Applications.

If You want to use this with NETCore 2.X you can Publish the native app.
Go into the Publish-Folder and modify the EXE SUBSYSTEM. This changes the Comsole-Application to a Windows-Application:)

```batch
 link.exe ConsleCaller.exe /SUBSYSTEM:WINDOWS
```

#### Create a Native Window
Create a new Class derive from NativeWindow

```c#
//Native Window
public class Window1:NativeWindow
{
	//Add your Controls
	//in this example a Button
	private NativeButton _Button;
	
	//Override InitControls Function
	protected override void InitControls()
	{
		//Set the properties of the Form.
		this.Text = "Dies ist meine Anwnedung";//Caption of the Window.
		this.Name = "Window1";
		this.Left = 100;
		this.Top = 100;
		this.Width = 600;
		this.Height = 400;
		
		//Create the Button
		this._Button = new NativeButton
		{
			Left = 10,
			Top = 10,
			Width = 100,
			Height = 30,
			Text = "Test",//Caption of the Button
			Name = "bnTest",
			ControlId = 501 //Currently every Control neads a unique ID. 
					//You must set it manually.
		};	
		//Add Eventhandler
		this._Button.Clicked += button_OnClicked;
		
		//Add the Button to the Window.
		this.Controls.Add(this._Button);
	}
	//Eventhandler for the Button
	private void button_OnClicked(object sender, EventArgs e)
	{
		//Show a Messagebox.
		MessageBox.Show("Button Clicked!");
	}
}
```
For more Details have a look at the Project ConsoleCaller.

#### Initialize the Application
To initilize the Application you have to create 2 Lines of Code in the Main-Function.
This is necessary because of Threading and Windows Messaging.
```C#
using CoreWindowsWrapper;

namespace ConsleCaller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the Window
            Window1 nw = new Window1();
            //Run the Application
            NativeApp.Run(nw);
        }
    }
}
```

I hope this helps in many Projects. 

##### Dipl.-Ing.(FH) Guido Agnesmeyer

