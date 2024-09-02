import React, { Children } from 'react'
import Header from '../../components/Header/Header'

const PaginaPadrao = ({children}) => {
  return (
    <div>
        <Header/>
        <div className='children'>
                {children}
            </div>

    </div>
  )
}

export default PaginaPadrao