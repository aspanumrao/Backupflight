import { passenger } from "./passenger";
export class Bookinghistory{
bookingDepartureDate:Date=new Date();
bookingFrom:string= '';
bookingReturnDate:Date=new Date();
bookingTo:string='';
emailId: string='';
flightNo:string='';
isBookingOneWay:boolean=true;
isBookingRoundWay:boolean=false;
isPNRNoActive:boolean=true;
listpassengers:passenger[]=[];
noOfSeat:number=0;
optForMeal:string='';
pnrNo:string='';
}