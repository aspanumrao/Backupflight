import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminflightInvComponent } from './adminflight-inv/adminflight-inv.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { UserflightsearchComponent } from './userflightsearch/userflightsearch.component';

const routes: Routes = [
  {
    path:"login",
    component:LoginComponent

  },
  {
    path:"register",
    component:RegisterComponent

  },
  {
    path:"adminflight-inv",
    component:AdminflightInvComponent

  },
  {
    path:"userflightsearch",
    component:UserflightsearchComponent

  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
