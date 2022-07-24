import "./index.css";

// function MyApp(props) {
//     return (
//         <>
//             <div>{props.adi}</div>
//             <div>{props.soyadi}</div>
//             <div>{props.yasi}</div>
//         </>
//     );
// }

function MyApp({ adi, soyadi, yasi, ikinci, books, detail, calisan }) {
    return (
        <div className="App-Border-2">
            <h2>My App Component</h2>
            <hr />
            <div>{adi}</div>
            <div>{soyadi}</div>
            <div>{yasi}</div>
            {calisan && <div>Bu personel çalışıyor.</div>}
            {!calisan && <div>Bu personel çalışmıyor.</div>}

            <ul>
                {
                    books.map((b,i) => <li key={i}>{b}</li>)
                }
            </ul>
        </div>
    );
}

export default MyApp;