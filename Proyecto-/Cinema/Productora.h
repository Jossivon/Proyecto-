using namespace std;

class Productora{
	string codigo;
	string nombre;
	public:
		Productora(){}
		Productora(string codigo,string nombre){
			this->codigo=codigo;
			this->nombre=nombre;
		}
		//Metodos set y get
		
		//Metodos de acceso
		string getCodigo(){
			return codigo;
		}
		string getNombre(){
			return nombre;
		}
		//Metodos de modificacion
		void setCodigo(string codigo){
			this->codigo=codigo;
		}
		void setNombre(string nombre){
			this->nombre=nombre;
		}
};
