import MyApp from './components/MyApp';
import UsingState from './components/UsingState';
import UsingStateArray from './components/UsingStateArray';
import UsingStateObject from './components/UsingStateObject';
import UsingStateInput from './components/UsingStateInput';
import './App.css';

function App() {
  const ad = "Murat";
  const soyad = "Başeren";
  const yas = 30;
  const details = { address: "asdasd", country: "turkey", postalcode: 80090 };
  const books = ["kitap1", "kitap2", "kitap3", "kitap4"];
  const ikinciAd = "Kadir";
  const calisanmi = true;

  return (
    <div className="App-border">
      <h2>App Component</h2>
      <hr />
      {/* <MyApp adi={ad} soyadi={soyad} yasi={yas} ikinci={ikinciAd} books={books} detail={details} calisan={calisanmi}  /> */}
      {/* <UsingState /> */}
      {/* <UsingStateArray /> */}
      {/* <UsingStateObject /> */}
      <UsingStateInput />
    </div>
  );
}

export default App;
