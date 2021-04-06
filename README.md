# RentalCars

We are the proud owners of "Iasi Rentals" car rental company.
We have 3 categories of cars: *Regular*, *Premium* and *Mini*.
Our rates are as following:

* *Regular*: 20EUR/day for the first 2 days + 15EUR/day per each additional day
* *Premium*: 30EUR/day
* *Mini*:    15EUR/day for the first 3 days + 10EUR/day per each additional day

We have also a *Customer Loialty* program:
* For each rental a customer receives 1 *FrequentRenterPoint*
* For each Premium rental over 2 days a customer receives 2 *FrequentRenterPoints*
* Customers who have at least 5 *FrequentRenterPoints* receive 5% discount on every rental.

Our business is going so well that we decided to open a new office in Bucharest.
To accomodate this new office we need to implement some changes to our software:
* The prices for Bucharest will be higher
	* 30EUR/day for Regular Cars. Adjust all other prices to be proportional to the Regular price
* We want to add a new category called *Luxury* 
* *Luxury* cars cost 70EUR/day and we offer NO DISCOUNTS for them
* *Luxury* cars can only be rented to loyal customers who have at least 3 *FrequentRenterPoints*

* We also need a new kind of statement grouped by car category to better see what our customers prefer:  

	Category&nbsp;&nbsp;&nbsp;&nbsp;Total Income  
	
	Regular&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;220EUR  
	Premium&nbsp;&nbsp;&nbsp;&nbsp;5000EUR  
	Mini&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;220EUR  
	Luxury&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1520EUR  

Please update the software so it can work in both Iasi and Bucharest offices and to offer both kinds of Statements.
Feel free to refactor everything as you wish as long as you follow all the industry best-practices you have learned so far.

**PS:**
Also, we suspect there is a bug somewhere in the statement generation, sometimes it displays the wrong price for rentals.
Please find it and fix it.
