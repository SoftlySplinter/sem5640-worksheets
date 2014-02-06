# Introduction to Visual Studio

## Introduction

This worksheet is designed to familiarise you with some of the features in Visual Studio to build ASP.NET applications. By the end of this worksheet, you should be able to do the following:

1. Create a new Console project in Visual Studio.
2. Create a new class and use it in an application.
3. Build and run the project.

The following sections describe the tasks that you should complete for this practical.

## Launching Visual Studio

Go to the Start menu and select All Programs. Find Visual Studio 2012 under the Development section. Click to start.

### Solutions and Projects  

Visual Studio works with Solutions, which can contain Projects. Each solution can contain multiple sub-projects. The Solution Explorer, on the right of the screen, shows the current project. When you create a new project, you can choose to create a new solution or add the project to the currently open solution.

### Error Lists

The Error List and Output panes are located at the bottom of the tool. Compilation errors will be shown in the Error List pane. When you get a compilation error, double click the error to go to the line in the source code.

### Auto Completion

When typing identifier names, Visual Studio will provide a list of options that can be auto completed. Generally, when you start typing a new identifier, or press the ‘.’ character the tool will search for a list of options. As with other development tools, press tab, space or return to accept the current selection.

You can also press the Ctrl+Space keys together to complete the current identifier, if possible, or to offer a list of options.

### Documentation

Documentation is available via a web interface or via a local install. Select
*Help > View Help* to bring up a search window. You can configure your preference
for local or web help by selecting *Help > Manage Help Settings*.


Additional documentation is available online at http://msdn.microsoft.com/

Go to this website, and enter the names of some namespaces in the .NET
Framework. Enter the names of some namespaces, e.g. `System.IO` and
`System.Collections`, to find out more about the Classes available. Look for
details of the Assembly that the class belongs to. The following example is for
the class `System.Web.UI`.

Examples are given in several of the .NET languages, typically VB (Visual Basic.NET, C#, C++ and F#).

The .NET class documentation is arranged hierarchically. Each topic has a general overview page and then several pages for details of the members (e.g. Constructors, Methods and Properties).

## Creating a Console Application

You will start out by creating a simple console application. This will give you an opportunity to write some C# code. We will then move onto creating an ASP.NET application. We will return to using a console application when we look at the use of web services.

### Step 1: Create a new application

1. Open Visual Studio
2. Select File > New > New Project. A new project dialog will be displayed.
3. Ensure that Visual C# is selected on the tree on the left of the panel. Select Console Application from the middle of the panel.
4. Enter a name for the project, e.g. CSharpPractical; this will be used to define the namespace for the classes that you have created.
5. A new project will be created. This will contain a single class file. The project files are listed in the Solution Explorer panel (typically on the right of the window). To edit the class file, double click it in in the Solution Explorer. C# files have the extension .cs. Edit the Project.cs file. The following shows the initial state of the Console Application.
6. Note that several namespaces have already been included. If you look at the Solution Explorer, you will also see that there is an item for References. Within the References section, there are the names of assemblies that are to be used when building the application.

In the Main method, enter the following:

```C#
Console.WriteLine("My first C# program");
Console.ReadLine(); // used to pause the program
```

### Step 2: Building and running the application

There are several ways that you can build the application:

* Press the Shift+Ctrl+B keys together.
* Select Build > Build Solution
* Right click on the solution name in the Solution Explorer.

These options will build the entire solution, which can include multiple projects. If you have multiple projects, you might choose to build a specific project rather than the entire solution. Look for other options under the Build menu to achieve this, or right-click on the project name in the Solution Explorer and select Build. 

Once the project has been built successfully, press F5 to run the application in debugging mode. 

Notes:
* You can also use Ctrl-F5 to run the application without debugging.
* Running the application will also cause the current project to be built.

### Step 3: Adding a new Class file to the project

From the Solution Explorer, right-click on the project name. Select the Add submenu, and then select Class. In the dialog, enter Person as the name of the class and press OK. A new file has been added to the Solution Explorer. 

Add a constructor to the Person class that take the forename, surname and age.

Add properties to the Person class, to hold the forename, surname and age. It should be possible to set and retrieve each of the properties. Include a ToString() method. An example class is provided on the following pages.

Notes:

* The ToString() method overrides the default implementation provided in the parent class. To do this, you must explicitly indicate that you intend to do this by adding the keyword override before the return type for the method.
* The example class is in the namespace CSharpPractical. If you did not choose this as the project name, your namespace will be different. To manage this, simply change the name of the namespace from CSharpPractical in the following code.

Modify the Program class. Prompt the user for input for the three properties for a person. Create a new person object and insert the values. Print out the values. An example is provided on the following pages.


### Run the code

Run the code. If you run by pressing F5, you will see that the program runs, but the console window disappears as soon as you have completed entering the data. In debug mode, the application will terminate immediately.

One way to address this for the console program is to run without debugging by pressing Ctrl+F5, which will pause when the program exits.

Another alternative is to add a breakpoint to pause the program execution and run through the different steps using the debugger. To add a breakpoint, click in the grey bar on the left of the editor. The breakpoint is shown as a red circle. When running in Debug Mode (i.e. F5) the program execution will pause at this point. If you hover the mouse over variables, tooltips will display the values.

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPractical
{
	class Person
	{
		private string forename;
		private string surname;
		private int age;

		public Person()
		{
			// no-op
		}

		public Person(string forename, string surname, int age)
		{
			this.forename = forename;
			this.surname = surname;
			this.age = age;
		}

		public string Forename
		{
			get { return forename; }
			set { forename = value; }
		}

		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public override string ToString()
		{
			return forename + " " + surname + ", age: " + age;
		}
	}
}
```

```C#
using System;
using System.Collections.Generic;
using System.Text;
namespace CSharpPractical
{
	class Program {
		public void run() {
			Person p = new Person();
			Console.Write("Enter forename: ");
			string forename = Console.ReadLine();
			Console.Write("Enter surname: ");
			string surname = Console.ReadLine();
			int age = 0;
			while ( ! IsAgeValid(age) )
			{
				Console.Write("Enter age: ");
				string ageStr = Console.ReadLine();
				try
				{
					age = Int32.Parse(ageStr);
					if (!IsAgeValid(age))
					{
						Console.WriteLine(
						"Please enter an age between 1 and 110");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("The age you entered was not recognised as a valid age. Please try again.");
					Console.WriteLine(ex.Message);
				}
			}
			p.Forename = forename;
			p.Surname = surname;
			p.Age = age;
			Console.WriteLine("The person is: " + p);
		}

		public Boolean IsAgeValid(int age) {
			return (age >= 1 && age <= 110);
		}
		
		static void Main(string[] args) {
			Program program = new Program();
			program.run();
		}
	}
}
```

### Create a list of Person objects

Look at the .NET documentation for the class System.Collections.Generics.List. Create a list of Person objects and iterate over the list to output the details. Hint: add a definition of: 

```C#
List<Person> people = new List<Person>();
```

Also, think about using the foreach loop statement. The syntax is:

```C#
foreach(Person person in people) {

}
```

### Modify the Namespace

In the new class, modify the namespace so that it is different from the namespace in the original class file. For example, modify it to M5640.CSharpPractical. In the Program.cs file, add a reference to the modified namespace by including a using statement. 

### Visual Studio Tip: Cold Folding

On the left of the text editor you will see + and – symbols in the margin. These indicate whether a block of code can be ‘folded’. This can be useful if you want to hide a block of code on the screen to make it easier to focus on other code.

The – symbol indicates that the code block is expanded. In the example below, you can see two code blocks: (i) the namespace and (ii) the class. Other blocks include methods.

To collapse a section of code, press the – symbol. In the following example, the class block has been collapsed. Here, you can now see the + symbol next to the class, which indicates that the block of code has been folded. Press the + symbol to expand the code. When expanded, the symbol is shown again.

Question: What happens if you collapse a block and move your mouse over the … section?


You can also create your own areas of code that can be folded by using `#region`
and `#endregion`. Try putting these lines around the while loop in the Program class. For example:

```C#
#region Some text to describe the region
while( ! IsValidAge(age) )
{
	…
}
#endregion
```

After a few seconds you will see that there is a code folding block (- symbol) available on the line for #region.
