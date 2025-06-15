import { Link } from 'react-router-dom';

const Header = () => {
    return (
        <header>
            <Link to="/">Mente Saudável</Link>
            <Link to="/usuario/cadastro">Cadastro</Link>
        </header>
    )
}

export default Header;