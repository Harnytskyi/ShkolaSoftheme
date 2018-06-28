import { Component } from '@angular/core';
import {ArticlesListService} from './article-list.services';
import {Article} from './article-model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  //providers: [ArticlesListService]
})
export class AppComponent {
  articles = [];
  /*articles =[
    'qwe',
    'qwe2'
 ];*/
  // articles: any[] = [{
  //   id: 458,
  //   name: 'Den',
  //   title: 'Заголово'
  // ]
    
  
  constructor (private articlesListService: ArticlesListService ) {
  this.articles = this.articles
  }
  
}
