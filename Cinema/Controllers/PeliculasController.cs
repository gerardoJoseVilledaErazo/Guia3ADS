using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class PeliculasController : Controller
    {

        // GET: Peliculas/Aleatorias
        public ActionResult Aleatorias()
        {
            Pelicula pelicula1 = new Pelicula() {Id = 1, Nombre = "Shrek", Genero = "Animacion, Aventura, Comedia", AnioLanzamiento = "2001", Clasificacion = "PG" };

            //pelicula1.nombre = "Shrek"; Otra forma en que se puede añadir

            return View(pelicula1);
            //return Content("Hola Mundo!");
            //return HttpNotFound();
            //return RedirectToAction("Index","Home",new { pag = 1, OrdenadoPor="nombre"});
        }
        /*
        public ActionResult Editar(int id)
        {
            return Content("Id: " + id);
        }
        */
        //GET: /Peliculas/
        /*
        public ActionResult Index(int? pagIndex, String ordenadoPor)
        {
            if (!pagIndex.HasValue)
                pagIndex = 1;
            if (String.IsNullOrWhiteSpace(ordenadoPor))
                ordenadoPor = "Nombre";

            return Content(String.Format("Indice de Pagina={0}&Ordenado por ={1}",pagIndex,ordenadoPor));
        }
        */

        //GET: /Peliculas/PorFechaLanzamiento/year/mes
        /*
        public ActionResult PorFechaLanzamiento(int year, int mes)
        {
            return Content(year + "/" + mes);
        }
        */

        //******************************************** GUIA 3 - ADS ***************************************************
        //GET: /Películas/peliculas/
        public ActionResult peliculas()
        {
            return View();
        }

        public ActionResult por_nombre()
        {
            List<Pelicula> listP = new List<Pelicula> {
                new Pelicula() {Id = 1, Nombre = "Shrek", Genero = "Animacion, Aventura, Comedia", AnioLanzamiento = "2001", Mes = "05", Clasificacion = "Todo público" },
                new Pelicula() {Id = 2, Nombre = "Toy Story", Genero = "Animación, Aventura, Comedia", AnioLanzamiento = "2010", Mes = "06", Clasificacion = "Todo público" },


                new Pelicula() {Id = 3, Nombre = "Titanic", Genero = "Drama, Romance", AnioLanzamiento = "1997", Mes = "12", Clasificacion = "No recomendado menores de 12 años" },
                new Pelicula() {Id = 4, Nombre = "Deadpool", Genero = "Acción, Ciencia ficción", AnioLanzamiento = "2016", Mes = "02", Clasificacion = "No recomendado menores de 18 años" },
                
                new Pelicula() {Id = 5, Nombre = "El Padrino", Genero = "Drama, Crimen", AnioLanzamiento = "1972", Mes = "03", Clasificacion = "No recomendado menores de 13 años" },
                new Pelicula() {Id = 6, Nombre = "La vida es bella", Genero = "Drama, Comedia, Romance", AnioLanzamiento = "1998", Mes = "10", Clasificacion = "Todo público" },

                new Pelicula() {Id = 7, Nombre = "Batman: The Dark Knight", Genero = "Acción, Drama, Misterio", AnioLanzamiento = "2008", Mes = "07", Clasificacion = "No recomendado menores de 13 años" },
                new Pelicula() {Id = 8, Nombre = "El Señor de los Anillos: El Retorno del Rey", Genero = "Aventura, Fantasía, Acción", AnioLanzamiento = "2003", Mes = "12", Clasificacion = "No recomendado menores de 13 años" }
                
            };
            List<Pelicula> lP = listP.OrderBy(Nombre => Nombre.Nombre).ToList();
            return View(lP);
        }
        public ActionResult por_fecha(String Year = "", String Mes = "")
        {
            List<Pelicula> listP = new List<Pelicula> {
                new Pelicula() {Id = 1, Nombre = "Shrek", Genero = "Animación, Aventura, Comedia", AnioLanzamiento = "2001", Mes = "05", Clasificacion = "Todo público" },
                new Pelicula() {Id = 2, Nombre = "Toy Story", Genero = "Animación, Aventura, Comedia", AnioLanzamiento = "2010", Mes = "06", Clasificacion = "Todo público" },


                new Pelicula() {Id = 3, Nombre = "Titanic", Genero = "Drama, Romance", AnioLanzamiento = "1997", Mes = "12", Clasificacion = "No recomendado menores de 12 años" },
                new Pelicula() {Id = 4, Nombre = "Deadpool", Genero = "Acción, Ciencia ficción", AnioLanzamiento = "2016", Mes = "02", Clasificacion = "No recomendado menores de 18 años" },

                new Pelicula() {Id = 5, Nombre = "El Padrino", Genero = "Drama, Crimen", AnioLanzamiento = "1972", Mes = "03", Clasificacion = "No recomendado menores de 13 años" },
                new Pelicula() {Id = 6, Nombre = "La vida es bella", Genero = "Drama, Comedia, Romance", AnioLanzamiento = "1998", Mes = "10", Clasificacion = "Todo público" },

                new Pelicula() {Id = 7, Nombre = "Batman: The Dark Knight", Genero = "Acción, Drama, Misterio", AnioLanzamiento = "2008", Mes = "07", Clasificacion = "No recomendado menores de 13 años" },
                new Pelicula() {Id = 8, Nombre = "El Señor de los Anillos: El Retorno del Rey", Genero = "Aventura, Fantasía, Acción", AnioLanzamiento = "2003", Mes = "12", Clasificacion = "No recomendado menores de 13 años" }

            };
            List<Pelicula> lP = listP.Where(Fecha => Fecha.AnioLanzamiento == Year && Fecha.Mes == Mes).ToList();
            return View(lP);
        }
        public ActionResult seleccionar_year_mes()
        {
            return View();
        }
        
        public ActionResult por_genero(Int32 Op)
        {
            List<Pelicula> lP=null;
            List<Pelicula> listP = new List<Pelicula> {
                new Pelicula() {Id = 1, Nombre = "Shrek", Genero = "Animación, Aventura, Comedia", AnioLanzamiento = "2001", Mes = "05", Clasificacion = "Todo público" },
                new Pelicula() {Id = 2, Nombre = "Toy Story", Genero = "Animación, Aventura, Comedia", AnioLanzamiento = "2010", Mes = "06", Clasificacion = "Todo público" },


                new Pelicula() {Id = 3, Nombre = "Titanic", Genero = "Drama, Romance", AnioLanzamiento = "1997", Mes = "12", Clasificacion = "No recomendado menores de 12 años" },
                new Pelicula() {Id = 4, Nombre = "Deadpool", Genero = "Acción, Ciencia ficción", AnioLanzamiento = "2016", Mes = "02", Clasificacion = "No recomendado menores de 18 años" },

                new Pelicula() {Id = 5, Nombre = "El Padrino", Genero = "Drama, Crimen", AnioLanzamiento = "1972", Mes = "03", Clasificacion = "No recomendado menores de 13 años" },
                new Pelicula() {Id = 6, Nombre = "La vida es bella", Genero = "Drama, Comedia, Romance", AnioLanzamiento = "1998", Mes = "10", Clasificacion = "Todo público" },

                new Pelicula() {Id = 7, Nombre = "Batman: The Dark Knight", Genero = "Acción, Drama, Misterio", AnioLanzamiento = "2008", Mes = "07", Clasificacion = "No recomendado menores de 13 años" },
                new Pelicula() {Id = 8, Nombre = "El Señor de los Anillos: El Retorno del Rey", Genero = "Aventura, Fantasía, Acción", AnioLanzamiento = "2003", Mes = "12", Clasificacion = "No recomendado menores de 13 años" }

            };

            switch (Op)
            {
                case 1:
                    lP = listP.Where(Genero => Genero.Genero == "Acción" || Genero.Genero == "Acción, Ciencia ficción" || Genero.Genero == "Aventura, Fantasía, Acción" || Genero.Genero == "Acción, Drama, Misterio").ToList();
                    break;
                case 2:
                    lP = listP.Where(Genero => Genero.Genero == "Animación" || Genero.Genero == "Animación, Aventura, Comedia").ToList();
                    break;
                case 3:
                    lP = listP.Where(Genero => Genero.Genero == "Aventura" || Genero.Genero == "Animación, Aventura, Comedia" || Genero.Genero == "Aventura, Fantasía, Acción").ToList();
                    break;
                case 4:
                    lP = listP.Where(Genero => Genero.Genero == "Ciencia ficción" || Genero.Genero == "Acción, Ciencia ficción").ToList();
                    break;
                case 5:
                    lP = listP.Where(Genero => Genero.Genero == "Comedia" || Genero.Genero == "Animación, Aventura, Comedia" || Genero.Genero == "Drama, Comedia, Romance").ToList();
                    break;
                case 6:
                    lP = listP.Where(Genero => Genero.Genero == "Crimen" || Genero.Genero == "Drama, Crimen").ToList();
                    break;
                case 7:
                    lP = listP.Where(Genero => Genero.Genero == "Drama" || Genero.Genero == "Drama, Crimen" || Genero.Genero == "Drama, Romance" || Genero.Genero == "Drama, Comedia, Romance" || Genero.Genero == "Acción, Drama, Misterio").ToList();
                    break;
                case 8:
                    lP = listP.Where(Genero => Genero.Genero == "Fantasía" || Genero.Genero == "Aventura, Fantasía, Acción").ToList();
                    break;
                case 9:
                    lP = listP.Where(Genero => Genero.Genero == "Misterio" || Genero.Genero == "Acción, Drama, Misterio").ToList();
                    break;
                case 10:
                    lP = listP.Where(Genero => Genero.Genero == "Romance" || Genero.Genero == "Drama, Comedia, Romance" || Genero.Genero == "Drama, Romance").ToList();
                    break;
                default:
                    lP = listP;
                    break;
            }
            return View(lP);
        }
        public ActionResult seleccionar_genero()
        {
            return View();
        }

    }
}