import { Component, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Router, ActivatedRoute } from "@angular/router";

@Component({
  selector: 'app-livro-edit',
  templateUrl: './livro.edit.component.html'
})
export class LivroEditComponent {
  private livro: LivroDTO;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router, @Inject('BASE_URL') private baseUrl: string) {
    this.livro = {
      id: 0,
      nome: '',
      autor: '',
      editora: '',
      anoPublicacao: 0
    };
  }

  ngOnInit() {
    this.route.params.subscribe(p => {
      if (p['id']) {
        this.http.get<LivroDTO>(this.baseUrl + 'api/livros/' + p['id']).subscribe(result => {
          this.livro = result;
        }, error => console.log(error));
      }
    });
  }
  
  salvar(livroEditado) {
    if (livroEditado.id > 0) {
      this.http.put(this.baseUrl + 'api/livros/' + livroEditado.id, livroEditado).subscribe(x => {
        this.router.navigate(['/']);
      }, error => console.log(error));
    } else {
      this.http.post(this.baseUrl + 'api/livros', livroEditado).subscribe(x => {
        this.router.navigate(['/']);
      }, error => console.log(error));
    }
  }
}

interface LivroDTO {
  id: number;
  nome: string;
  autor: string;
  editora: string;
  anoPublicacao: number;
}
