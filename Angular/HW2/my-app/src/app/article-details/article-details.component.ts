import {Component} from '@angular/core';
@Component({
  selector: 'app-articledetails',
  templateUrl: './article-details.component.html'

})
export class ArticleDetailsComponent {
  article: any[] = [{
    id: '1',
    title: 'Порошенко мав телефонну розмову з Вакарчуком: відомі деталі',
    shortDescription: 'Президент України Петро Порошенко телефонував до музиканта, лідера групи "Океан Ельзи" Святослава Вакарчука. Під час розмови чоловіки не оминули і тему політики.'
  }];
  stringColor: string = '#000000'; //Default Color
  changeColor(){
    this.stringColor = '#CCCCCC'; 
  }
  heading:string="НОВИНИ";
}
