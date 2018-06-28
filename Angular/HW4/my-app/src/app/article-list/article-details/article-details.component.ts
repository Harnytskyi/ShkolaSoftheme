import { Component, Input, EventEmitter, Output } from '@angular/core';

import { ArticleModel } from './article.model';
@Component({
  selector: 'article-details',
  templateUrl: './article-details.component.html',
  styleUrls: ['./article-details.component.css']
})
export class ArticleDetailsComponent {
  @Input()
  article: ArticleModel;
  stringColor: string = '#000000'; //Default Color
  changeColor(){
    this.stringColor = '#CCCCCC'; 
  }
}
