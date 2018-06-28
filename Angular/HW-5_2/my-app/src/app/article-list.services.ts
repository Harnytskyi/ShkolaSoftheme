import {Article} from './article-model';

export class ArticlesListService{
/*articles = [
    {name: 'amf 1'},
    {name: 'amf 2'},
    {name: 'amf 3'},
    {name: 'amf 4'},
]
*/
articles: Article[] =  [{
    name: 'qwe',
    title: 'qwe2'
}];

 getArticles(): Article[]{
     return this.articles;
 }
}