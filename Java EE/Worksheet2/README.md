# JavaEE Worksheet 2

We are going to play with a simple world of departments and staff. We will 
largely do this through the use of NetBeans wizards for producing typical 
components.

### Departments have

* A name
* A phone number

### Staff have

* A name
* A national Insurance number
* A phone number
* An age
* A pay Grade (1-8)

Each member of staff belongs to one department. Departments may have many 
staff.

## Creating a database

It will be sensible to have you own JavaDB database to work in
<sup>[1](#foot1)</sup>.

In the Services tab under the expandable Databases will be an expandable JavaDB
 item. This may contain one or more example databases distributed with 
NetBeans, including `sample`. You need a new database.

Right click on `JavaDB`, create a new database giving a Name, User name and 
Password.

You will have a new connection created, at the same level as JavaDB in the 
Database hierarchy.

Right click on it and choose `Connect`. It is now a browsable hierarchy showing
the databases in the server with tables, views and stored procedures in each. 
There will be a database of the name you specified, with no contents. The 
others are system databases.

This database is now available to be used as a data source. While developing, 
you can investigate the database structure using this interface. If the 
database table structures changes, it may be convenient to delete tables here 
as well. Test data could also be entered.

## A Web Application

### Step 1

Create a new web application including the JavaServer Faces framework.

### Step 2

Create the two JPA entities to support this model. Use New → Entity Class ...
You will be prompted for a Persistence Unit and offered the chance to create 
one.

* Name it what you like (or take the default name)
* Use EclipseLink (JPA 2.1) as the persistence provider.

* You will be asked for a data source. You will need to create one using the 
  pull down option "New Data Source ... ". The "Create Data Source" pop up will
  let you choose a JNDI name (by convention this will be jdbc/xxx - where you 
  can choose xxx). The "Database Connection" pull-down should include the 
  connection you created earlier. Use that. NetBeans will re-use the details 
  you gave the IDE earlier for connection from the application.

The second Entity which you create will re-use the persistence unit you created
for the first<sup>[2](#foot2)</sup>.

The Entities, as created by the wizard, will have just an Id property. For the 
first prototype add some suitable field types for each Entity, perhaps with 
some simple constraints. Simply adding properties for each field (and thereby 
taking the default @Column settings) will be fine for now. You may want to 
come back and look at entity level validation later.

Remember that each member of staff needs a Department. You will need a 1:M 
association using an instance variable.

### Step 3

We will use a wizard to create a lot code. Use New -> JavaServer Faces -> JSF 
Pages from Entity Classes and select both entities during the dialog. Put 
Session Beans, JSF Classes and JSF Pages in separate packages for now. Consider
later a suitable package structure for this type of application.

### Step 4

Run and test your application. Errors in the JPA entities may not show up until
you run the application. Your will have any such errors in the NetBeans 
Glassfish 4.0 output pane.

Test particularly:

* Whether you can create a staff member with no Department? Are you prompted 
  (with a pulldown) for a department? 
* Any constraints you have put on values via their underlying database fields.

### Step 5

Investigate your implementation:

* Draw a UML diagram of the classes you now have.
* What EJBs do you have (note how NetBeans shows these twice).
* Do the EJBs have business interfaces? What methods do they "export"?
* How are the three \*Facade classes working together? What do the concrete 
  facade classes add to the abstract one?
* What is the relationship between the \*Controller classes and the EJBs.
* Track down the JSF pages:
  * How does `h:dataTable` in the List.xhtml pages work? What session bean
    method(s) does it rely on?
  * What is javax.faces.model.DataModel and how is it used in the session
    beans? (Look for the JavaDocs).
  * Both the Create and Edit pages use the selected property of controller 
    beans. How can that be right?
  * Why do some of the controller methods return strings such as "List", "View"
    etc.?
* Trace the use case of creating a new member of staff. Start with the Create 
  JSF page, go right through to the database and then back to the JSF page 
  displayed after "Save" is pressed.

### Step 6

Keep this code and have it accessible for the Worksheet 3 session.

---

<a name="foot1"></a><sup>1</sup> If you have an account on another RDBMS 
instance and the NetBeans has drivers for it, you can experiment if you wish.

<a name="foot2"></a><sup>2</sup> Under Configuration Files in your project you 
will find persistence.xml. This is where the connection to the persistence 
store is defined. It was created by the wizard, but is editable directly if 
necessary.
