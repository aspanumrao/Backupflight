import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { RegisterComponent } from './register/register.component';
import { HttpClientModule } from '@angular/common/http';
import { AdminflightInvComponent } from './adminflight-inv/adminflight-inv.component';
import { UserflightsearchComponent } from './userflightsearch/userflightsearch.component';
import { TicketBookingComponent } from './ticket-booking/ticket-booking.component';
import { BookinghistoryComponent } from './bookinghistory/bookinghistory.component';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { UserdashComponent } from './userdash/userdash.component';
import { NewuserComponent } from './newuser/newuser.component';
import { AdmindashComponent } from './admindash/admindash.component';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    AdminflightInvComponent,
    UserflightsearchComponent,
    TicketBookingComponent,
    BookinghistoryComponent,
    UserdashComponent,
    NewuserComponent,
    AdmindashComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
