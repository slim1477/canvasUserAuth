import { useParams } from "react-router-dom";
import { useEffect } from "react";
import { VerifyButton } from "@/components/verification/VerifyButton";
import { ProfileDetails } from "@/components/Profile/ProfileDetails";
import ProfileTabs from "@/components/Profile/ProfileTabs";
import { fetchMember } from "@/utils/utils";
import { useMemberStore } from "@/store/memberStore";

export default function Profile() {
  const {
    updateId,
    updateEmail,
    updateFirstName,
    updateLastName,
    updateDateOfBirth,
    updateAddress,
    updatePhone,
  } = useMemberStore();
  let { memberId } = useParams();

  useEffect(() => {
    if (memberId) {
      fetchMember(memberId)
        .then((member) => {
          updateId(member.id);
          updateEmail(member.email);
          updateFirstName(member.firstName);
          updateLastName(member.lastName);
          updateDateOfBirth(member.dob);
          updateAddress(member.address);
          updatePhone(member.phoneNumber);
        })
        .catch((error) => {
          console.error("Error fetching member:", error);
        });
    }
  }, [memberId]);

  return (
    <section className="mt-5 px-3 grid gap-5 lg:grid-cols-[30%_auto] lg:grid-rows-3 lg:p-[15px] lg:grid-flow-col xl:grid-cols-[27%_auto]">
      <div className="rounded-lg lg:row-span-2 lg:col-start-1">
        <div className="flex flex-col gap-5 rounded-lg lg:col-start-1">
          <div className="shadow-md bg-background rounded-lg">
            <ProfileDetails />
          </div>
          <div className="h-[50px] lg:w-[50%] lg:flex lg:justify-end">
            <VerifyButton />
          </div>
        </div>
      </div>
      <div className="lg:row-span-3 lg:col-start-2">
        <div className="h-[600px] border rounded-lg shadow-md bg-background">
          <ProfileTabs />
        </div>
      </div>
    </section>
  );
}
