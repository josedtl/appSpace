// import "primereact/resources/themes/lara-light-cyan/theme.css";
import { Button } from 'primereact/button';
import { Calendar } from 'primereact/calendar';

function App() {

  return (
    <>
      <div >
              
        <Button 
        className="middle none center mr-4 
        flex items-center justify-center rounded-lg bg-gradient-to-tr 
        bg-DRgreen hover:bg-DRgreenOscuro
        p-3 font-sans text-xs font-bold uppercase 
        text-white shadow-md  transition-all hover:shadow-lg             
        disabled:shadow-none"
        label="Check" icon="pi pi-check" />
      </div>

<Calendar/>


    </>
  )
}

export default App
