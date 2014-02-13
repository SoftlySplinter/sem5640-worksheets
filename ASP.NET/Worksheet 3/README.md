# Building  a  Business  Layer  in  ASP.NET  

##Introduction  

This worksheet is designed to introduce you to creating an ASP.NET application that implements part of a BookStore application. You will create a business layer that will retrieve data from a SQL Server database file and provide this information to the presentation layer.

## Application  Structure  

The application will use multiple pages (WebForms) to provide the functionality for the site; this practical will build one of the pages. The structure of each page will be relatively simple. The pages will link to a Business Layer that will control data retrieval and update.

The application will store data in a SQL Server database. The database contains the following tables:

* Category – A list of categories.
* Book – A list of books, each of which is associated with a single category.
* Order – The main details for an order.
* OrderItem – A list of items, each of which is associated with a specific order.

This practical will only consider the Category table.

The Business Layer will contain Business Logic classes and Data Access classes. This practical will guide you through the steps to create the Data Access Layer using a Typed Data Set. The Business Layer will be built as a separate Class Library project and linked into the main Web project.

## Objectives  

The objectives are:

* Build a simple database to store Category information. You will create a database file that is associated with the SQL Server Express tool that is installed with Visual Studio.
* Build a Data Access Layer using a Typed Data Set.
* Build a Business Logic classes to provide access to the Category data. This class will provide links to create, retrieve, update and delete Category data.
* Retrieve information from the database and display it in a GridView control.
* Build a WebForm to create, edit and display records from the Category table.

The following sections describe the tasks for this practical.

## Create  a  new  Web  Application  Project  

Open Visual Studio and create a new ASP.NET Empty Web project. Set the name as BookStore.

## Create  a  new  Database

In a full ASP.NET project, the database would be on a separate server. For this
project, we can include a local database in an special App\_Data directory IIS will prevent any HTTP accesses to the files in this directory.

### Create  a  SQL  Database  File    

1. Right click on the main project in the Solution Explorer.
2. Select Add > Add ASP.NET Folder > App\_Data, which will add a new folder to the Solution Explorer.
3. Right click the App\_Data directory.
4. Select Add > New Item.
5. In the Add New Item dialog, select SQL Server Database. Enter a name, e.g. BookStoreDB.mdf. Press the Add button to confirm the operation.

The database will be added to the App\_Data directory.

## Create  a  new  table  in  the  file  and  add  test  data  

Select the Server Explorer Tab. This is normally located on the left of the screen net to the Toolbox tab. If you cannot see the Server Explorer, select the menu option View > Server Explorer to display the tab.

The tab will show a link to the new database file that you have just created. Expand the tree to reveal several subfolders, including Database Diagrams, Tables and Stored Procedures.

Right click on the Tables directory and select the Add New Table option. A new Table editor screen is show.

Enter the following columns:

* id – set the type to int. Also, right click on the id row to display a context sensitive menu. Select the option to set the row as the Primary Key.
* Next, in the properties area at the bottom of the screen, find the entry for Identify Specification. Click on the symbol to expand a set of options. Change the (Is Identity) row to True. When this is set to true, the database will manage the values in the id field, automatically generating a unique number for each record.
* name – set the type to nvarchar(50)
* description – set the type to nvarchar(50)

In the T-SQL area, change the name from [dbo].[Table] to [dbo].[Category].

Uncheck the Allows Nulls for each of the columns. An example of the configured table is shown in the following screenshot.

When the table is ready, click the Update button at the top of the table editing panel. On the following dialog, click Update Database.

The Category table is now part of the database, but it might not be listed as one of the tables in the Server Explorer. You can right-click on the Tables part of the database and select the Refresh option. When the table is displayed, you will see the following.

Right click on the table name and select the option Show Table Data. An empty database table is displayed. Enter a row of data. Enter values for the name and description columns. You do not need to enter the id field; SQL Server will automatically create a new id for each row entered. Click in the second (empty) row to confirm the details in the first row. An example is shown below.

### Test  the  database  connection  

The next step is to test the basic connection to the database.

1. Add a Default.aspx WebForm to the project and switch to the Design view for the WebForm.
2. From the Toolbox, which is typically on the right as a tab next to the Serve Explorer, drag a GridView control from the Data section; scroll down the list of controls to find the Data section.
3. A grid is displayed and a popup dialog is shown to display several key options for the control.
4. Select the Choose Data Source drop-down list. Select the `<New Data Source…>` option. The following dialog is displayed. Select the Database icon.  Enter a name, e.g. BookStoreDataSource, for the data source. Press the OK button.
5. Set the data connection to the mdf file that you have created. Press Next.
6. Uncheck the option to store the connection string in the Configuration file. It is usually desirable to leave this option selected, to allow configuration of a data source without recompiling code. It is acceptable to ignore the option for this practical.
7. The next screen shows the option to configure the Select statement. Ensure that the table category is selected. Select the * column, to indicate that all columns should be retrieved. Press Next.
8. Press Next. The following Test Query screen will be shown. Click on Test Query and confirm that the data is retrieved. Click Finish when you have confirmed the data connection.
9. A new control has been added to the page. This is a SqlDataSource control. It is only used to provide a link between the GridView control and the database. The SqlDataSource control does not generate any HTML in the final page display.

Next, run the application. When the page is displayed, it should contain a table that shows the data that you entered into the category table. This mechanism provides a quick way to verify that you can access data in the database. Look at the Source view for Default.aspx. Note that the control for asp:SqlDataSource includes a SQL command. The data access logic has been embedded in the presentation layer, which is undesirable. You will change this in the remainder of the practical.

## Creating  the  Business  Layer  

The Business Layer will consist of two types of objects: Business Logic and Data Access. The aim is to separate any logic required to manage the data from the mechanism to access the data. This practical will use a Typed Data Set to provide access to the data. It is possible to define other Data Access mechanisms, including Custom classes that handle the underlying data sources, e.g. a database.

### Create  a  Class  Library  project  

You will build the Business Layer as a separate Class Library project. Select File > Add > New Project from the main menu. The following dialog is displayed.

Select Class Library from the Visual C# project types. Enter the name BusinessLayer. Press the OK button. A new project will be added to the Solution Explorer. It will have a single class file, Class.cs. The project will use the namespace BusinessLayer as the top-level namespace for all classes that are generated.

### Data  Access  

The next step is to create a data set that will be used as the Data Access Layer. The data set will provide the direct access to the database table. A later step is to define a Business Logic class that will provide the link between Presentation Layer (the ASP.NET WebForms) and the data store.

To create the dataset, right-click on the new project (BusinessLayer) and select Add > New Item. In the following dialog, select DataSet and enter a name, e.g. BookStoreDS.xsd.

A new editor tab is displayed. From the Toolbox on the left of the screen, drag a TableAdapter control onto the editor pane. The TableAdapter provides a mechanism to provide read and update access to a data source, which in this practical is the category table in the SQL Server database file.

The TableAdapter Configuration Wizard is displayed. This is used to setup a link to the underlying data source. On the first screen, select the SQL Server file that you have created. Press Next.

As with the earlier project, uncheck the option to save the item in the configuration info. Press Next. The next screen is used to determine how the TableAdapter will connect to the database. Select Use SQL statements and press Next.

Enter a SQL statement that is used to retrieve the data from the data store. Enter the statement select * from category. Before you press Next, press the Advanced Options button.

By default, each of the three options on the Advanced Options dialog is selected. Uncheck the Use optimistic concurrency and Refresh the data table options. These are not required for this practical. Press OK.

The next step is to choose the names of the methods that are used to access a list of data from the database. Accept the default names and options. Press the Finish button.

A new item is added to the DataSet diagram. It lists the fields from the database table and the methods that have just been created. The TableAdpter has also generated several basic methods to insert, update and delete data in the category  table, although they are not shown in this display. It is possible to add other methods to the TableAdapter, but they are not required for this example.

### Business  Logic  

A basic Data Access class has now been defined. The next step is to define a BusinessLogic class. Add a new class, called CategoryBL, to the BusinessLayer project. The basic class definition is shown below.

```C#
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.BookStoreDSTableAdapters;
namespace BusinessLayer
{
  public class CategoryBL
  {
    private CategoryTableAdapter categoryAdapter = null;
    protected CategoryTableAdapter Adapter
    {
      get
      {
        if(categoryAdapter == null)
        {
          categoryAdapter = new CategoryTableAdapter();
        }
        return categoryAdapter;
      }
    }

    public BookStoreDS.CategoryDataTable GetData()
    {
      return Adapter.GetData();
    }

    public int Update(String name, String description, int id) 
    {
      return Adapter.Update(name, description, id);
    }

    public int Delete(int id) 
    {
      return Adapter.Delete(id);
    }

    public int Insert(string name, string description) 
    {
      return Adapter.Insert(name, description);
    }
  }
}
```

The class will use the Data Adapter to access the data. The adapter is stored as a private variable and it is accessed in the class through the property Adapter. This is done for convenience so that the logic to create the class is located in one section. This simplifies the content of the other methods.

The GetData method returns a table of data. This table can be bound to a Web
Control, which provides a simple mechanism to show the data in a web form. The
Update, Delete and Insert methods return a count of the number of rows that have
been affected. We would expect the number to be 1 for each of these specific
calls. These methods are designed to update, delete or insert a single row of
data at a time.

The method declarations are simple for this example class. The methods could be
used to specify business logic or to check the data values before they are
passed to the data access class. In this situation, the database will perform
several checks on the data, e.g. testing for null or checking if a text value
will fit in the field in the database. Therefore, it is desirable to let the
underlying data source perform some of these checks in an effort to avoid
defining the same rules in multiple locations.

Build the BusinessLayer project to confirm that it compiles. An easy way to do this is to right-click on the project in the Solution Explorer, and press Build.

## Linking  the  Business  Layer  to  the  Presentation  Layer  

The next step is to link the BusinessLayer project to the Web Site project. To do this, you need to add a reference into the Web Site project. Select the WebSite project in the Solution Explorer and right-click. Select the item Add Reference.

In the dialog that is displayed, select the Solution > Projects item on the left. This shows a list of other projects in the solution that you can link to. Select the BusinessLayer project. This will setup a link so that when the Web Site project is built, it copies the current DLL assembly from the BusinessLayer project. The DLL is copied into the bin directory in the WebSite project.

Once the reference is setup, the Web Site code can access the classes in the BusinessLayer.

### Admin  Category  Page  
Next, add a page to the project to manage the category data. Firstly, add a new directory, called Admin to the Web Site project. Next, add a WebForm into the WebSite project called Category.aspx; select the default Master page in the project, which is Site.Master. Switch to Design view for the page.

From the Toolbox, drag a GridView control onto the page; this is located in the Data section of the page. On the GridView Tasks panel, select the option <Add New Source> from the drop-down list. Select the Object item from the list of data source entries. Accept the default name and press the Next button. On the next screen, select the value BusinessLayer.CategoryBL from the list of business objects; you will need to uncheck the Show only data components checkbox to view this item. Press the Next button.


On the next screen, link the different methods from the CategoryBL class up to
the Select, Update, Insert and Delete tasks.

Press Finish. You will see a new ObjectDataSource control added to the page. As
with the SqlDataSource that you created earier, this is only visible in the
Design mode and it does not get rendered HTML at runtime.

Select the small arrow at the top-right of the GridView control. From the GridView Tasks panel, you will see new options including Enable Paging, Enable Editing and Enable Deleting. Tick each of these options.

Run the application and view the page Admin/Category.aspx. Check that the data from the table is displayed.  Press the Edit button to edit the values in the table.

Next, add in a FormView control from the Data section of the Toolbox. You will use this control as a quick way to insert new records into the database. You need to link the control a data source. Connect it to the ObjectDataSource that you have just added. You only need to connect the Insert command for this control.

From the properties panel for the FormView control, find the Default Mode
property. Change this to have the value Insert. This will set the control ready
to accept new data. The control will use the Insert method in the CategoryBL
class to create a new entry.

Run the page again. Use the FormView control to enter new data. When the page is
refreshed, you will see the new data displayed in the GridView control. What
happens if you do not enter any data and press the Insert button?Can you catch
the error in the Insert method in CategoryBL?

Can you return a value from this method if there is an error, e.g. return -1 to
indicate that there was an error when inserting the row. An example is shown
below.

```C#
public int Insert(string name, string description)
{
  try
  {
    return Adapter.Insert(name, description);
  }
  catch
  {
    return -1;
  }
}
```

Next, on the FormView, respond to the event ItemInserted. Within this event
handler, check the return value and display a message if there was an error. Can
you do that?

An alternative is to get rid of the change to the Insert operation above. Then,
use the following as an example for handling an error. How does this work?

```C#
protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
{
  if(e.Exception != null)
  {
    System.Diagnostics.Debug.WriteLine("Need to handle the error");
    e.ExceptionHandled = true;
  }
  else 
  {
    System.Diagnostics.Debug.WriteLine("That was fine.");
  }
}
```

Look at the source for the page in your Web browser. Look at the size of the
ViewState data. Do you think that the control will need to use the ViewState?
What happens to the page if you disable the ViewState for the control?

### Data  View  Controls  

For further information about the capabilities of the ADO.NET data controls used
in this example, see chapters 10 and 11 in Programming Microsoft ASP.NET 2.0,
Core Reference by Dino Esposito. There are several copies of the book in the
library. The chapters cover more detail that you will require for this module,
but they provide a general background to connecting DataSet data to controls.
