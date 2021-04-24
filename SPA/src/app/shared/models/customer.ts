import { Service } from "./service";

export interface Customer {
    id: number;
    cName: string;
    address: string;
    phone: string;
    email: string;
    services: Service[];
}
