using namespace std;

class Protagonista{
	string papel;
	public:
		Protagonista(){
			
		}
		Protagonista(string papel){
			this->papel=papel;
		}
		//Metodos set y get
		
		//Metodos de acceso
		string getPapel(){
			return papel;
		}
		//Metodos de modificacion
		void setPapel(string papel){
			this->papel=papel;
		}
	
};
