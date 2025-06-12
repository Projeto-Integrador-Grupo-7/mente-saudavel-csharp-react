import { useEffect } from 'react';
import api from './services/api';

function App() {
    let usuarios = []

    async function getUsuarios() {
        const retorno = await api.get('https://localhost:7054/api/usuarios');

        usuarios = retorno.data;
        console.log(usuarios);
    }

    useEffect(() => {
        getUsuarios()
    }, []);

    return (
        <div>
            <h1>Página provisória</h1>
        </div>
    )
}

export default App;