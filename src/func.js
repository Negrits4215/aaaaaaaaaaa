import respuestaser from "./services/respuestaser";
import preguntaser from "./services/preguntaser";
import temaser from "./services/temaser";
import sql from "mssql";

class Funciones{

    getTemas = async() => {
        let svc = temaser();
        let data;
        data = svc.getTema();
        console.log(data)
        return data;
    }

    getTemasbyid = async(idt) => {
        let svc = temaser();
        let data;
        data = svc.getTemaByid(idt);
        console.log(data)
        return data;
    }

    getPregunta = async(idt) => {
        let svc = preguntaser();
        let data;
        data = svc.getPregunta(idt);
        console.log(data)
        return data;
    }

    getRespuestas = async(idp) => {
        let svc = respuestaser();
        let data;
        data = svc.getRespuestas(idp);
        console.log(data)
        return data;
    }
}

export default Funciones