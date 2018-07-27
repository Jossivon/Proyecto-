using namespace std;

class Director{
	string codigo;
	string nombre;
	public:
		Director(){}
		Director(string codigo, string nombre){
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
		void setCodigo(){
			this->codigo=codigo;
		}
		void setNombre(){
			this->nombre=nombre;
		}
};
