# _{Vendor and Order Tracker}_

#### By _**{Liliia Kryvelova}**_

https://github.com/liliiakryvelova/VendorAndOrder.git

#### _{You've been referred by Pierre to his friend Claire who is the owner of a hair salon called Eau Claire's Salon. She has contracted you out to create an MVC web application to help her manage her employees (stylists) and their clients. Claire should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist.}_

## Technologies Used

* _ASP.NET Core MVC_
* _Razor_

## Description

* _We want to establish a one-to-many relationship between the Clien and Stylist entities where many Clients are associated with one Employee(Stylist). It means that each Client entity points to an Employee. This can be achieved by including a reference navigation property Stylist in the Client entity class. In the same time, the Clients table includes foreign key._

* _Another convention is to include a collection navigation property in the Stylist entity as shown below._

* _The Client entity includes foreign key property StylistId with its reference property Stylist. Thi will create one-to-many  relationship with NotNull foreign key column in the Clients table, as shown below._

* _The homepage of the app at the root path should be a splash page welcoming Eau Claire's Salon and allow adding a new Stylist, add a new Client._

* _The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage._

* _Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders._

* _As the salon owner, I need to be able to see a list of all stylists._
* _As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist._
* _As the salon owner, I need to add new stylists to our system when they are hired._
* _As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added._

## Setup/Installation Requirements

* _Clone this git on your local computer *For clonning: use button Clone -> from repository. *Copy the clone command(SSH format or HTTPS)._
* _From a terminal on your local computer, use command "cd" to find the directory where you want to clone this repository. *Type the command ($ git clone HTTPs)._
* _If you clone successfully , a new sub-directory appears on your local computer. *For working with project, run : dotnet restore._
* _In the next step, run: dotnet build._
* _For running the project, run -> dotnet run(in the cmd or terminal)._ 



## Known Bugs


## License


Copyright (c) _7-30-2022_ _Liliia Kryvelova(s)_
