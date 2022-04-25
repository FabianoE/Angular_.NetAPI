import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
})
export class EventosComponent implements OnInit {
  public eventos: any = [];
  public eventosFiltrados: any = [];
  isCollapsed = true; //Mostrar imagem
  private _filtroLista: string = '';

  public get filtroLista() {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.eventosFiltrados = this.filtroLista? this.filtrarEventos(this.filtroLista): this.eventos;
  }

  constructor(private http: HttpClient) {}

  filtrarEventos(filtro: string): any {
    filtro = filtro.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: any) =>
        evento.tema.toLocaleLowerCase().indexOf(filtro) !== -1 ||
        evento.local.toLocaleLowerCase().indexOf(filtro) !== -1
    );
  }

  ngOnInit() {
    this.getEventos();
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      (response) => {
        this.eventos = response;
        this.eventosFiltrados = response;
      },
      (error) => console.log(error)
    );
  }
}
