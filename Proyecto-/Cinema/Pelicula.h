using namespace std;
#include "Director.h"
#include "Productora.h"

class Pelicula{
	Director director;
	Productora productora;
	string codigo;
	string titulo;
	string clasificacion;
	public:
		Pelicula(){
			
		}
		Pelicula(string codigo, string titulo , string clasificacion,Director director, Productora productora){
			this->codigo=codigo;
			this->titulo=titulo;
			this->clasificacion=clasificacion;
			this->director=director;
			this->productora=productora;
		}	
		
		//Metodos set y get
		
		//Metodos de acceso
		Director getDirector(){
			return this->director;
		}
		Productora getProductora(){
			return this->productora;
		}
		string getCodigo(){
			return codigo;
		}
		string getTitulo(){
			return titulo;
		}
		string getClasificacion(){
			return clasificacion;
		}
		//Metodos de modificacion
		void setDirector(Director director){
			this->director=director;
		}
		void setProductora(Productora productora){
			this->productora=productora;
		}
		void setCodigo(string codigo){
			this->codigo=codigo;
		}
		void setTitulo(string titulo){
			this->titulo=titulo;
		}
		void setClasificacion(string clasificacion){
			this->clasificacion=clasificacion;
		}
		
};
