# prac

This is going to be simple practice planner.

## It should:

* Check resources for availibility while booking the resoure.
* Check for a maximum number of bookings for a resource while booking.
* Result in a plan or calendar (for a given period) holding all the bookings.
* Automaticly create bookings for a given dateTimeRange by choosing the "best" resource in the following way:
    * Shortest distance from my home.
    * Minimum number of bookings, e.g. a resource with one booking should be choosen over a resource with two bookings.
    * A resource that is less available should be choosen over a resource that is highly available.

## What's a booking?
A resource blocked for a given dateTimeRange added to the calendar.

### A resource should have:
* One or more contact person(s).

## Contact person

* Should have a preferred way of contact, may it be letter, email, SMS, etc.
* Ensure that the required information for the preferred way of contat is available (adderss, email address, phone number).