# JavaEE Worksheet 3

## An Enterprise application


### Step 1

Use New -> Java EE -> Enterprise application to create a new "Enterprise" 
project.

Note the 3 projects. You will be deploying both the `ejb` and the `war` to one 
server (one JVM) and NetBeans will coordinate this via the third level project.
When you make changes to one or other project, it is safest to "Run" the top 
level project rather than just the one you may have edited.


### Step 2

Create a desktop enterpise application client (New Project Java EE Enterprise
Application Client);

### Step 3

In the `ejp` project, create a "Stateless" Session EJB. (New Enterprise 
JavaBeans Session Bean). Make sure it is Stateless and create a remote 
interface in the desktop project you have just created.

### Step 4

The desktop application now has the remote interface with an appropriate name. 
Add two methods to it:

```java
double cTof(double c);
double fToc(double f);
```

### Step 5

The EJB (not being abstract) now requires implementations. The methods are for 
converting Celsius to Fahrenheit and visa versa. These are just trivial 
"Enterprise" services which can be called. Give the implementations which are:

```java
return ((9.0D / 5.0D) * c) + 32;
```

```java
return (f - 32) * (5.0D / 9.0D);
```

### Step 6

Copy the generated remote interface (in its package(s) as appropriate) from the
desktop application to the war project so that it can be used there as well.

Add a servlet to the war project which calls one of the EJB methods. You should
inject the EJB using its remote interface type.

Run the enterprise application (which will load the `ejb` and the `war` 
projects) to test the servlet (Right click on the servlet editor pane offers 
"Run file ..." which will run the servlet, avoiding the necessity to create an
`index.xhtml` or type the URL to call it).

### Step 7
Inject the EJB into the main class of the desktop client. Add a new method to 
the main class. Instantiate the main class in its main method and call a new 
method on it. In that method, call on the EJB.
