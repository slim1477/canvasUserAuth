import aculogo from "@/assets/Header/acu-logo.png";
import canvaslogo from "@/assets/Header/canvas.jpg";

const Header = () => {
  return (
    <header className="flex bg-background relative w-full justify-between items-center px-1.5 py-3 lg:p-3 border-b-4 lg:border-b-[10px] border-b-primary-accent">
      <div>
        <img className="h-9 lg:h-[60px]" src={canvaslogo} alt="canvas" />
      </div>
      <div>
        <img className="hidden lg:flex lg:h-[60px]" src={aculogo} alt="acu" />
      </div>
    </header>
  );
};

export default Header;
