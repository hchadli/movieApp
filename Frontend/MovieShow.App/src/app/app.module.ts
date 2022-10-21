import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClient, HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { MovieComponent } from './movie/movie.component';
import { MovieThumbComponent } from './movie-thumb/movie-thumb.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    MovieComponent,
    MovieThumbComponent,
  ],
  imports: [BrowserModule],
  providers: [HttpClientModule],
  bootstrap: [AppComponent],
})
export class AppModule {}
