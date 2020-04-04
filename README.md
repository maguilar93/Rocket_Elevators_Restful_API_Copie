# Rocket_Elevators_Restful_API


Odyssey Week 8

Rocket Elevators New REST API

How to answer the 9 questions in Postman :

1- To Get a specified Battery current status, do :

    GET https://rocketelevatorsrestful.azurewebsites.net/api/batteries/5	[5 = specified battery ID]
    SEND
2- To Modify the status of a specified Battery, do :

    PUT https://rocketelevatorsrestful.azurewebsites.net/api/batteries/5	[5 = specified battery ID]
    SEND
    An error will appear in the field, that's ok.
    Select:	 Body
                Raw
                JSON application
    In the text field, enter:

{
	"status": "Active" _or_ "Inactive"  _to change the status_ 
} 

    SEND
    You can verify if the change succeeded by doing a new GET on that specified Battery.
3- To Get a specified Column current status, do :

    GET https://rocketelevatorsrestful.azurewebsites.net/api/columns/5 [5 = specified column ID]
    SEND
4- To Modify the status of a specified Column, do :

    PUT https://rocketelevatorsrestful.azurewebsites.net/api/columns/5 [5 = specified column ID]
    SEND
    An error will appear in the field, that's ok.
    Select:  Body
                Raw
                JSON application
    In the text field, enter:

{ 
	"status": "Active" _or_ "Inactive"  _to change the status_ 
} 

    SEND
    You can verify if the change succeeded by doing a new GET on that specified Column.
5- To Get a specified Elevator current status, do :

    GET https://rocketelevatorsrestful.azurewebsites.net/api/elevators/5 [5 = specified elevator ID]
    SEND
6- To Modify the status of a specified Elevator, do :

    PUT https://rocketelevatorsrestful.azurewebsites.net/api/elevators/5 [5 = specified elevator ID]
    SEND
    An error will appear in the field, that's ok.
    Select:  Body
                Raw
                JSON application
    In the text field, enter:

{ 
	"status": "Active" _or_ "Inactive"  _to change the status_ 
} 

    SEND
    You can verify if the change succeeded by doing a new GET on that specified Elevator.
7- To Get the elevators list that are not in use at the moment (with the status "Inactive" or "Alarm"), do :

    GET https://rocketelevatorsrestful.azurewebsites.net/api/elevators
    SEND
8- To Get a buildings list that have at least one Battery, one Column or one Elevator needing an intervention, do :

    GET https://rocketelevatorsrestful.azurewebsites.net/api/buildings
    SEND
9- To Get a Leads list that are not our clients yet since the last 30 days, do :

    GET https://rocketelevatorsrestful.azurewebsites.net/api/leads
    SEND 
