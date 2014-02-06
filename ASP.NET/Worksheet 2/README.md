# Building  an  ASP.NET  Web  Forms  Application  

## Introduction  
This worksheet is designed to familiarise you with some of the features in Visual Studio to build ASP.NET applications. By the end of this worksheet, you should be able to do the following:

1. Create a new ASP.NET WebForms project.
2. Add controls to a Web Form. The form will process user input and change the output based on the data.
3. Experiment with different HTML and Web controls.
4. Use the Visual Studio debugger on the website.
5. Redirect a user to a new page.
6. Add a Master Page to an application and build a new Web Form that uses the Master

The following sections describe the tasks that you should complete for this practical.

## Launching  Visual  Studio    

Go to the Start menu and select All Programs. Find Visual Studio 2012 under the Development section. Click to start.

## Creating  a  Web  Application  project  

In this next stage, you will create an ASP.NET Web Application. This is creating using the ASP.NET Web Forms that we have discussed in the lectures. There is an alternative method, which is to create a Web site project. For a discussion of the difference, see http://msdn.microsoft.com/en-us/library/ie/dd547590.aspx.

### Step  1:  Create  a  Web  Application  project  

1. Open Visual Studio
2. Select File > New > Project…
3. In the New Project dialog, select the ASP.NET Empty Web Application option; ensure that C# is selected on the left. Enter a project name, e.g. MiniBookStore. Press OK.
4. A new project will be created, with minimal content at this stage. The Web.config file is used to configure the behaviour of the application. The initial state of the project does not include any web forms.
5. To create a web form, select the project name and right-click. From the menu, select Add > Web Form, as shown in the following screenshot.
6. A dialog window is shown. Enter the name Default. Press OK.
7. A new Web Form is added to the project. It is called Default.aspx.

## Step  2:  Adding  Controls  to  the  Page    

Switch to Design Mode for the Default.aspx page. Add controls to the Default.aspx Web Form so that it looks like the following screenshot. The controls are:

* A TextBox to enter the ISBN.
* A Button to start the search.
* A Label to show the result.

The Search title and the Enter ISBN text can be just entered using standard HTML tags.

You only need to enter code in the Form area in the page. You can do this in either the Design view or the Source view; these views can be selected at the bottom of the editor window.

The corresponding Source view would be as shown below. Instructions on what to add are on the next page.

Add the following to the page:

1. A title element, with the text Search. Mark this as an H1 element in the ASPX source. It is also possible to use the formatting toolbar to set the style for a block of text. The formatting toolbar can be activated from the View > Toolbars menu. 
2. DIV element and within the DIV, enter the text Enter ISBN add a TextBox. Set the (ID) property of the TextBox to IsbnText.
3. Add a Button. Set the (ID) property to IsbnButton. Set the Text property to Search by ISBN.
4. Add another DIV and also add a Label. Set the (ID) to ResultsLabel. Set the Text property to an empty string.

Note When creating WebForms, you should set the ID for each element to a name that is appropriate to the application. This will make it easier to remember which items you need to work with in the code-behind file.

Press F5 to view the current page in the default web browser.

A new ASP.NET Development Server will be launched. It will be displayed in the system tray in the bottom right of the screen. This will remain in the system tray until you close it or close Visual Studio. If you close it and then need to run your web application again, simply run the project and a new instance of the Development Server will be started.

Once the server has started, the web page will be displayed in your default browser. You should see that all of the controls are visible. Try to press the button. Note that this generates a Postback to the server. Nothing changes because we have not associated any action with the button yet. The page is redisplayed.

Note When you run the ASP.NET project in debugging mode, you will see that Visual Studio changes the display. You cannot modify the application at this point. To stop the debugging mode, select the Stop Debugging option from the Debug menu. The Debug mode will launch the application using Internet Explorer. You can run the application without the debugger. To do this, start the application by pressing Ctrl-F5.

## Step  3:  Defining  the  action  for  the  button  

Display the code-behind file for the Default.aspx file. There are two ways that you can do this. 

From the editor for Default.aspx, right click and select the View Code option. Alternatively, expand the tree for the Default.aspx file in the Solution Explorer and double click the Default.aspx.cs file.

You will see the code-behind file in a new editor window. This is the partial
class that was described in the lectures. It has one method defined, `Page_Load`, which will be called each time that the page is loaded by ASP.NET in response to a request for the page.

Return to the Design Mode view for the Default.aspx file. Double click the IsbnButton that you added in an earlier step. You will see that the Default.aspx.cs file is displayed. A new method has been added which will handle the button click event.

In the method, add a block of code to implement the following algorithm; please note that the following is not C# code – the challenge for you is to write this as C# code. Hint: Access the Text properties for IsbnText and ResultLabel to access the string text value. Also, use String.Format() to format the ResultLabel to replace the {0} with the ISBN value that is entered on the Web Form. Look up the documentation for String.Format on MSDN (http://msdn.microsoft.com/en-us/library/system.string.format.aspx).

```
If IsbnText value is equal to “1234” then 
	Set ResultLabel to “The book is ‘Programming ASP.NET with C#” 
Else 
	Set ResultLabel to “Sorry, but the ISBN {0} has not been found” 
End If
```

Press F5 to run the application again. Press the button. Check that when the page is redisplayed that it includes the messages that you entered in the previous step. Stop the application.

Modify the application so that the message is only shown if the text box is not empty. Hint: You can use the Trim method of a String object to remove all whitespace at the start and end of the string; see http://msdn.microsoft.com/en-us/library/system.string.trim.aspx.

## Step  4:  Adding  a  validation  control    

Add a Required Field Validator to the page and set the ID to IsbnValidator. This control will check that the specified control contains a value when the form is submitted.

In the properties tab for the control, set the ControlToValidate to the IsbnText control. Set the Text property to include a prompt to be displayed to the user if they haven't entered a value, e.g. * Please enter the ISBN.

Run the application. Try to submit the form without entering a value. Then, enter a value and try to submit the form again. You should see that an error message is shown on the first attempt and that the page is not posted back to the server. The page should be posted back as normal when you have entered a value in the textbox.

Modify the EnableClientScript property. Set this to false to disable the client-side validation check. What happens now that this is disabled? What change could you make to the server-side code to handle this change so that you have the same output in the web page?

Hint: The RequiredFieldValidator has a Property called IsValid. You can use this to test if the control that is required has a value or not. If the field is not valid, you can return from the method without checking the value further.

Try the following sequence of actions when EnableClientScript is set to false:

* Do not enter a value in the textbox and press the button.
* When the page returns, enter a value in the textbox and press the button
* When the page returns, clear the value from the text box and press the button.
* What has happened to the message label on the final step? Why does the label still have a value? Hint: think about the Visible property for the ResultLabel.


## Step  5:  Navigate  to  a  second  page    

In this step, you will add a second page to your project and setup a link so that the first page calls the second page.

1. Right-click on the project name in the Solution Explorer. Select Add New Item…
2. In the dialog, select Web Form. Set the name to Book.aspx. Press Add.
3. The dialog Select a Master Page is displayed. From the dialog, select the file Site.Master. Press OK.
4. In the new page, add a Label control and set the (ID) property to IsbnLabel.
5. In the Page_Load method, in the code-behind file, add the following line of code. This code will extract the value for an id element from the Query String. The Query String is the optional part of the page URL that follows the ? character.
6. Save the page.
7. In the Default.aspx page, add a new Hyperlink control. Set the name of the control to BookLink.
8. In the code-behind for Default.aspx, modify the method that responds to the button click. Change it so that it sets the NavigateUrl property to the string “~/Book.aspx?id=” + IsbnText.Text, if the ISBN is valid. Add code to hide the link if the IsbnText value is a recognised value, i.e. it isn’t “1234”.

Run the application, checking that the Hyperlink is displayed under the correct circumstances and that when the link is activated the browser goes to the Book.aspx page. The Book.aspx should display the Id value that is passed in the Query String.


## Step  6:  Using  a  Master  Page    

ASP.NET includes a feature called Master Pages. This feature is used to define the main outline for pages on a site, such as the header and footer. The default template for an ASP.NET web application in Visual Studio 2010 sets a Master Page, although we haven’t used it in this practical. The default file in the project is Site.Master. You can edit this file and even replace it.

Multiple Master Pages can be defined for a site for use in different areas of the site. In the following steps, you will define a simple Master page and apply it to a new page in your application.

1. Right click the project name in the Solution Explorer. Select Add New Item…
2. Select Master Page. You can choose to accept the default name or create a new name. Enter the name Default.Master. Press the OK button.
3. You will see the Master Page added to the project. It is opened in Source
mode. Note that there is an element called asp:contentplaceholder. This is used
to add in controls that are defined on other pages.
4. Add a new <div> element inside the <form> element, before the existing <div>. Add some text to be used as a Header.
5. Add a new <div> element just before the </form> element, after the existing </div>. Add some text to be used as a Footer.

An example of the source for the Master Page is shown below. You can change the extra content much as you want.

The next phase is to apply this Master Page to a new page.

1. Add a new ContentPage to the project.
2. On the dialog to define the Web Form using Master Page. Press OK. You will be shown a second dialog, that lists the Master pages that are defined in your application. Select the Master Page that you have created.
3. When the Web Form opens in the editor, notice that it does not define the full HTML for a page. Instead of generating a basic page, the Web Form is set to define the content that will be inserted into the asp:contentplaceholder element on the Master Page. When you are designing the content for the new page, you are defining the content for the placeholder.

If you make changes to the Master, they will be visible across all pages that use the Master

It is possible to rework a standard page to one that uses a Master Page, although it is a manual process involving 3 or 4 steps. It is better to decide early if you will be using Master Pages in an application to avoid the need to rework existing pages.

## Step  7:  Using  the  debugger  

Visual Studio includes an integrated debugger. This can be used to step through the execution of your web project when you are testing it in the local development server.

You can pause the program at a particular line and then use the controls to step through the code to see what is happening at different points.

In the grey bar on the left of the text editor you can enable and disable breakpoints. When the code reaches the line marked by the breakpoint, the execution will pause and you will be able to inspect data values in the program and step through the code line by line.

An example is shown below. Here, a breakpoint has been added to line 29. When the code reaches this point, you will be able to use the debugger to inspect the code.

There are standard features to continue, pause, stop, restart, step over and step into code blocks. The debugger menu is displayed in the tool, shown below. It provides access to the options.

To run in debug mode, you need to set the solution configuration to Debug. This can be done from the drop-down list on the toolbar. Generally, you will find it set to Debug by default. When it is in Debug mode, you can press the run button (the green triangle next to the Debug option).

This will run the program in debug mode.

Experiment with this feature to put breakpoints on different parts of your code.

## Step  8:  Add  in  a  Calendar      

So far, you have used some of the Web controls that are provided as ASP.NET controls. Have a look at the other controls. Look up the documentation for the class System.Web.UI.WebControls.Calendar. How do you access the selected date?

* Add a new Content Page that uses the Master Page. For example, call it Calendar.aspx.
* On the Web Form, drop a Calendar control into the content placeholder. Look at this within the Source view. It will have simple definition.
* In Design view for the page, select the Calendar. Notice that there is a small button with an arrow displayed in the top-right. Click on it. A context menu is shown to reveal an option to set the Auto Format. Select the option. In the dialog, select a different style and press OK.
* Switch to Source view again. Look at the amount of extra configuration elements and attributes that have been added. This is common for more complex controls.
* Add a label on the page and give it a sensible name.
* Double-Click on the calendar in Design view. This will add a default event, which is to cause a PostBack when the selection in the calendar has changed. You will see that a new method has been added in the code behind.
* In this method, get the SelectedDate property from the Calendar. Call ToString() on the date. Assign the value to the Text property of the Label that you added to the page.
* Run this page. To run a specific page, you can right-click on the page and select View in Browser (Internet Explorer).

## Compilation  /  Dynamic  Page  Compilation    

When you press the F5 key to run the application, Visual Studio will run a compilation of the code in your project. This stage is performed to check that your code is valid, i.e. that it will compile.

You do not need to compile the code before you run an ASP.NET project. As discussed in the lectures, ASP.NET will detect if the current version of a file is newer than any previously compiled version. If the file is newer, it is recompiled.

You can test this for yourself. Instead of using F5 to run the application, make a change to one of the aspx files and save the file. Then, refresh web browser. You will see the modified page after a short delay. What is happening during the short delay? Does an automatic compilation occur if the code-behind page is changed and saved?

## And  Finally…  For  Interest  

In the lectures, the Global Assembly Cache (GAC) was mentioned. This is a central location where assemblies can be located so that they are available to more than one application on the machine. In the GAC, you can see the DLLs that are shipped by Microsoft as part of the .NET Framework.

You can see the entries in the GAC by navigating to C:\Windows\assembly. An example is shown below.

To be entered into the GAC, the assembly must be signed. Whilst building assemblies is outside the scope of the module, this may be an issue to investigate in future work if you need to share assemblies.
