using namespace std;
#include "Pelicula.h"
#include "Protagonista.h"

class Participacion{
	Pelicula pelicula;
	Protagonista protagonista;
	string papel;
	public:
		Participacion(){
			
		}
		Participacion(string papel,Pelicula pelicula, Protagonista protagonista){
			this->papel=papel;
			this->pelicula=pelicula;
			this->protagonista=protagonista;
		}
		//Metodos set y get
		
		//Metodos de acceso
		string getPapel(){
			return papel;
		}
		Pelicula getPelicula(){
			return pelicula;
		}
		Protagonista getProtagonista(){
			return protagonista;
		}
		
		//Metodos de modificacion
		void setPapel(string papel){
			this->papel=papel;
		}
		void setPelicula(Pelicula pelicula){
			this->pelicula=pelicula;
		}
		void setProtagonista(Protagonista protagonista){
			this->protagonista=protagonista;
		}
};
