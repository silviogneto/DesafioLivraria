import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-livro',
  templateUrl: './livro.component.html'
})
export class LivroComponent {
  public livros: LivroDTO[];

  constructor(private http: HttpClient, private router: Router, @Inject('BASE_URL') private baseUrl: string) {
  }

  ngOnInit() {
    this.getAll();
  }

  getAll() {
    this.http.get<LivroDTO[]>(this.baseUrl + 'api/livros').subscribe(result => {
      this.livros = result;
    }, error => console.log(error));
  }

  editar(id) {
    this.router.navigate(['/livros/edit/' + id]);
  }

  deleteLivro(livro) {
    this.http.delete(this.baseUrl + 'api/livros/' + livro.id).subscribe(x => {
      this.getAll();
    });
  }
}

interface LivroDTO {
  id: number;
  nome: string;
  autor: string;
  editora: string;
  anoPublicacao: number;
}
