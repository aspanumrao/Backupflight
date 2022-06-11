import { passenger } from "./passenger";

export class BookingFlight{
    FlightNo:string='';
    PNRNo:string='';
    IsPNRNoActive:boolean=true;
    EmailId:string='';
    OptForMeal:string='';
    NoOfSeat:number=0;
    BookingFrom:string='';
    BookingTo:string='';
    BookingDepartureDate:Date=new Date();
    BookingReturnDate:Date=new Date();
    listpassengers:passenger[]=[];
    constructor() {
       

    }
}