import React, { Children } from 'react'
import Header from '../../components/Header/Header'

const PaginaPadrao = ({children}) => {
  return (
    <div className='container-pagina-padrao'>
        <Header/>
        <div className='container-children'>
          {children}
        </div>
    </div>
  )
}

export default PaginaPadrao