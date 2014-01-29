# JavaEE Worksheet 1

## Context

Write a JavaServer Faces application to input a name and contact details (address, ‘phone number,
e-mail address) and save them for a session. The context might be a retail web site where these
details can be entered at any time during the session and then used at checkout at the end. The
option to save these for a future session would require EIS tier components which we will get to
later. We will use the wizards to provide outline and boilerplate code and configurations. New
`Project` (File -> New project; Ctrl-Shift-N) and `New File` (File -> New File; Ctrl-N;
or
Right click in a project tree under Projects) are you friends here. Lots of standard items are available;
some dependant on the installation of plugins. Do read the code generated and ensure that you
understand ho it operates.

## Step 0

Create a new Java Web project (`File` -> New Project -> `Java Web` -> `Web
Application`)
under NetBeans. Consider the options you are given. Use the context sensitive help if unsure.
Settings can be changed afterwards under project properties (Right click on the project name in
Projects). Accept the “Server and Settings” values. Include JavaServer Faces as the framework when
prompted by the wizard. The wizard will add libraries to the project; create a boilerplate
`index.xhtml` facelet; create a `web.xml` and `beans.xml` configuration file and set up the
project properties.


## Step 1

Create a JSF Managed Bean – use the wizard (New  JavaServer Faces  JSF Manager
Bean) but consider the defaults and options. There is a pull down menu to set the bean scope. Add
the necessary properties to the class. Choose them yourself. You could come back and add to this
later so start with simple fields. (There is a wizard for boilerplate code insertion on the editor right
mouse click menu in the editor pane).


## Step 2

Create a JSF page, bound to the backing bean to collect the data. (New JavaSrver Faces
JSF Page). Add components (use the editor's completion facilities) . Use the EL to connect to
the managed bean (the “model”).


## Step 3

Create a JSF page to display the details. Demonstrate that the data are kept for the session. This will
probably involve a simple menu page to access the different page. Use implicit navigation for now.

New installations of NetBeans may take a long time to activate this feature, but will be faster on subsequent
runs.


## Step 5

Implement suitable validation for each field. Standard converters will suffice.


## Step 6

Create an application scoped bean to count the number of views that have been displayed. Invoke
the increment function from the view facelet and display the current total in that view as well.


## Step 7

You might like to employ the templating mechanism to generate a standard web page with, say, a
banner, a left hand menu including the edit and view options, and a content area. Much boiler plate
for a range of standard layouts is available in the New JavaServer Faces Facelets
Template wizard.


## Step 8

View the Domain Admin Console (Services Tab Servers Glassfish 4.0
right click). Investigate administration of your local server. Look for your application.


## Step 9

Swap server URLs with somebody else (or start more than one browser on your machine) and
demonstrate that the session and application scoped beans are working.
You can use the ipconfig command to find the hostname and primary dns suffix of the machine you
are running your server on. Alternatively, you can just take the numeric IP address. Others could
then access your server to demonstrate your session and application beans.


## References

* The JSF tag libraries are documented at http://docs.oracle.com/cd/E17802_01/j2ee/javaee/javaserverfaces/2.0/docs/pdldocs/facelets/index.html
* The JavEE documentation starts at http://docs.oracle.com/javaee/ which shows outlines for the templating.
