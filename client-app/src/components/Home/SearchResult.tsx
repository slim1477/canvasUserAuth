import card from "@/assets/card.png";
type Props = {
  memberName: string;
  email: string;
  address?: string;
  phone: string;
};
export const SearchResult = ({ memberName, email, address, phone }: Props) => {
  return (
    <section className="flex px-6 py-4 rounded-lg justify-between">
      <div className="flex items-center gap-6">
        <div className="w-6 h-6 lg:h-8 lg:w-8">
          <img src={card} alt="card" />
        </div>
        <div className="flex flex-col items-start">
          <p>{memberName}</p>
          {/* <p>Member Number</p> */}
        </div>
      </div>
      <div className="flex lg:w-[60%] items-center justify-between gap-4 lg:gap-10">
        <p className="">{phone}</p>
        <p className="hidden w-1/3 lg:flex">{address}</p>
        <p className="hidden lg:flex">{email}</p>
      </div>
    </section>
  );
};
