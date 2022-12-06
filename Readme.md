This program demonstates the work of the
Factory method, Builder and Singleton methods

This program converts from one file format to another
(Media like videos and audios, and Word)

Factory Method:
This pattern responsible for UI render logic.
All element will be rendered by the operating system name

Builder:
This is an important pattern in this project. It will build UI elements by following this rool:
for example I want to create a new button: 
{	
Button button = new Button();
button.AddLocation.Text().FontSize().SetActive(bool).Render()	
}