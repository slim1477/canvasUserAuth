import personlogo from "@/assets/Profile/person.png";

type Props = {
  memberName: string;
  memberNumber: string;
  dateOfBirth: string;
  phone: string;
  email: string;
  address: string;
};
export const ProfileDetails = ({
  memberName,
  memberNumber,
  dateOfBirth,
  phone,
  email,
  address,
}: Props) => {
  return (
    <section className="flex flex-col gap-4 p-4 items-center lg:items-start">
      <div className="flex gap-5 items-center">
        <div>
          <img src={personlogo} alt="person" className="h-11 lg:h-[60px]" />
        </div>
        <div className="flex flex-col items-start">
          <h1 className="text-xl">{memberName}</h1>
          <p className="text-slate-500 text-left">{`Member Number: #${memberNumber}`}</p>
        </div>
      </div>
      <div>
        D.O.B: <span className="text-slate-500 text-left">{dateOfBirth}</span>
      </div>
      <div>
        Phone: <span className="text-slate-500 text-left">{phone}</span>
      </div>
      <div>
        Email: <span className="text-slate-500 text-left">{email}</span>
      </div>
      <div className="text-left">
        Address: <span className="text-slate-500 ">{address}</span>
      </div>
    </section>
  );
};
