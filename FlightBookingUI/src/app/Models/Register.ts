export class Register{
FlightId:number=0;
FlightNo:string='';
FlightLogo:string='';
From:string='';
To:string='';
DepartureDate:Date=new Date();
ReturnDate:Date=new Date();
OneWay:boolean=true;
RoundWay:boolean=false;
IsFlightBlock:boolean=false;
Price:number=0;
AvailableSheet:number=0;

constructor(){}
// constructor( flightId:number, flightNo:string, flightLogo:string,from:string,to:string,departureDate:Date,returnDate:Date,oneWay:boolean, roundWay:boolean, isFlightBlock:boolean, price:number, availableSheet:number) {
//     this.FlightId=flightId,
//     this.FlightNo=flightLogo,
//     this.FlightLogo=flightNo,
//     this.From=from,
//     this.To=to,
//     this.DepartureDate=departureDate,
//     this.ReturnDate=returnDate,
//     this.OneWay=oneWay,
//     this.RoundWay=roundWay,
//     this.IsFlightBlock=isFlightBlock,
//     this.Price=price,
//     this.AvailableSheet=availableSheet


    
// }

}