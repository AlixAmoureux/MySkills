import { Framework } from './Framework';

export interface Language {
  id: number;
  name: string;
  framework?: Framework[];
}
