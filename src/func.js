import respuestaser from "./services/respuestaser";
import preguntaser from "./services/preguntaser";
import temaser from "./services/temaser";
import sql from "mssql";

    export async function getTemas() {
        let svc = new temaser();
        let data;
        data = await svc.getTema();
        console.log(data)
        return data;
    }

    export async function getTemasbyid(idt) {
        let svc = new temaser();
        let data;
        data = await svc.getTemaByid(idt);
        console.log(data)
        return data;
    }

    export async function getPregunta(idt) {
        let svc = new preguntaser();
        let data;
        data = await svc.getPregunta(idt);
        console.log(data)
        return data;
    }

    export async function getRespuestas(idp) {
        let svc = new respuestaser();
        let data;
        data = await svc.getRespuestas(idp);
        console.log(data)
        return data;
    }

