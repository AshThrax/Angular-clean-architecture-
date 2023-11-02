import { Song } from "./song";

export class Album {
  id: number;
  title: string;
  songs : Song[];

  constructor( id: number, title: string, songs : Song[])
  {
    this.id = id;
    this.title = title;
    this.songs=songs
  }
}
