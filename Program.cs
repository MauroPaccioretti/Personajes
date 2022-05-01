using Personajes;
PersonajeDeFuerza personajeDeFuerza = new("Odin", 30, 10);
PersonajeDeAgilidad personajeDeAgilidad = new("Loki", 20, 80, 30);
PersonajeDeMagia personajeDeMagia = new("Zeus", 5, 20);

List<Personaje> personajes = new List<Personaje>();
personajes.Add(personajeDeFuerza);
personajes.Add(personajeDeAgilidad);    
personajes.Add(personajeDeMagia);

Turno.Atacarse(personajes);

List<IMoverse> moverseList = new();

moverseList.AddRange(personajes);
moverseList.Add(new Enemigo());

foreach(IMoverse entidad in moverseList)
{
    Turno.MoverFichas(entidad);
}


